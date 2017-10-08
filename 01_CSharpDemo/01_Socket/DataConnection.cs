using System;
using System.Net.Sockets;

namespace _01_Socket
{
    internal class DataConnection
    {
        private Socket _newSocket = null;
        private Action<string> ShowMsg = null;
        public DataConnection(Socket socket, Action<string> showMsg)
        {
            _newSocket = socket;
            ShowMsg = showMsg;

            int recieveLen = 0;
            var buffer = new byte[1024 * 1024 * 2];
            try
            {
                recieveLen = _newSocket.Receive(buffer);//接受返回数据，返回的是实际接受的数据长度
                if (recieveLen == 0)
                {
                    _newSocket.Shutdown(SocketShutdown.Both);
                    _newSocket = null;
                    return;
                }
                else
                {
                    //添加处理程序
                }
            }
            catch (SocketException ex)
            {
                _newSocket.Shutdown(SocketShutdown.Both);
                ShowMsg(ex.Message);
                _newSocket.Dispose();
                throw;
            }
            catch (Exception ex)
            {
                _newSocket.Shutdown(SocketShutdown.Both);
                ShowMsg(ex.Message);
                _newSocket.Dispose();
                throw;
            }
        }
    }
}