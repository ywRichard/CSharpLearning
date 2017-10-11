using System;
using System.IO;
using System.Net.Sockets;
using System.Reflection;

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
                case ".aspx":
                    ProcessDynamicPage(request.FilePath);
                    break;
                default:
                    break;
            }
        }

        private void ProcessDynamicPage(string filePath)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);//获取没有扩展名的文件名
            var nameSpace = Assembly.GetExecutingAssembly().GetName().Name;//获取程序集名称（命名空间）
            var fullClassName = "_" + nameSpace + "." + fileName;//类的全称
            object obj = Assembly.GetExecutingAssembly().CreateInstance(fullClassName);//创建对象
            //var list = obj as List;
            var list = obj as IHttpHandlerModel;
            var msg = list.RenderHtml();
            var buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            var response = new HttpResponse(buffer, Path.GetExtension(filePath));
            newSocket.Send(response.GetHeaderResponse());//响应报文头
            newSocket.Send(buffer);
        }

        private void ProcessStaticPage(string fileName)
        {
            var dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = Directory.GetParent(dataDir).Parent.Parent.FullName;
            }
            var fullDir = dataDir + fileName;//获取处理的完整文件路径
            using (var fileStream = new FileStream(fullDir, FileMode.Open, FileAccess.Read))
            {
                var buffer = new byte[fileStream.Length];
                int length = fileStream.Read(buffer, 0, buffer.Length);//读取形态文件内容
                //构建响应报文
                var response = new HttpResponse(buffer, Path.GetExtension(fullDir));
                newSocket.Send(response.GetHeaderResponse());//发送请求报文头
                newSocket.Send(buffer);
            }
        }
    }
}