using System;
using System.Text;
namespace _01_SocketServer
{
    internal class HttpRequest
    {
        public string FilePath { get; set; }
        public HttpRequest(string msg)
        {
            var strs = msg.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var str = strs[0].Split(' ');
            FilePath = str[1];
        }
    }
}