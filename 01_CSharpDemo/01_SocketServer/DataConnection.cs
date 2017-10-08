using System;
using System.IO;
using System.Net.Sockets;

namespace _01_SocketServer
{
    internal class DataConnection
    {
        Socket newSocket = null;
        Action<string> ShowMsg = null;

        public DataConnection(Socket newSocket, Action<string> showMsg)
        {
            this.newSocket = newSocket;
            this.ShowMsg = showMsg;
            var buffer = new byte[1024 * 1024 * 2];
            var reciveLen = this.newSocket.Receive(buffer);//接受数据
            try
            {
                if (reciveLen != 0)
                {
                    var bufferStr = System.Text.Encoding.UTF8.GetString(buffer, 0, reciveLen);
                    this.ShowMsg(bufferStr);
                    var request = new HttpRequest(bufferStr);//对请求报文进行分析，获取请求的文件名称
                    ProcessRequest(request);
                }
                else
                {
                    this.newSocket.Shutdown(SocketShutdown.Both);
                    this.newSocket = null;
                    return;
                }
            }
            catch (SocketException ex)
            {
                this.newSocket.Shutdown(SocketShutdown.Both);
                newSocket.Dispose();
                ShowMsg(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                this.newSocket.Shutdown(SocketShutdown.Both);
                newSocket.Dispose();
                ShowMsg(ex.Message);
                return;
            }
        }

        //分析报文中文件的类型
        private void ProcessRequest(HttpRequest request)
        {
            var fileExt = Path.GetExtension(request.FilePath);
            switch (fileExt)
            {
                case ".html":
                case ".htm":
                case ".js":
                case ".css":
                case ".jpg":
                    ProcessStaticPage(request.FilePath);//对静态资源进行处理
                    break;
                default:
                    break;
            }
        }

        private void ProcessStaticPage(string fileName)
        {
            var dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\")||dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = Directory.GetParent(dataDir).Parent.Parent.FullName;
            }
            var fullDir = dataDir + fileName;//获取处理的完整文件路径
            using (var fileStream=new FileStream(fullDir,FileMode.Open,FileAccess.Read))
            {
                var buffer = new byte[fileStream.Length];
                int length = fileStream.Read(buffer,0,buffer.Length);//读取形态文件内容
                //构建响应报文
                HttpResponse response = new HttpResponse(buffer,Path.GetExtension(fullDir));
                newSocket.Send(response.GetHeaderResponse());//发送请求报文头
                newSocket.Send(buffer);
            }
        }
    }
}