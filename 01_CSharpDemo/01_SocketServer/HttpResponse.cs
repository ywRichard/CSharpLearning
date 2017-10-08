using System.Text;

namespace _01_SocketServer
{
    internal class HttpResponse
    {
        private byte[] _buffer = null;
        public string Content_Type { get; set; }
        public HttpResponse(byte[] buffer, string fileExt)
        {
            this._buffer = buffer;
            switch (fileExt)
            {
                case ".html":
                case ".htm":
                    Content_Type = "text/html";
                    break;
                case ".jpg":
                    Content_Type = "image/jpeg";
                    break;
            }
        }

        public byte[] GetHeaderResponse()
        {
            var sb = new StringBuilder();
            sb.Append("HTTP/1.1 200 ok\r\n");
            sb.Append("Content-Type:"+ Content_Type+";charset=utf-8\r\n");
            sb.Append("Content-Length:"+_buffer.Length+"\r\n\r\n");//在响应报文的最后一行下面有一个空行，所以在这里加两组"\r\n\r\n"
            return System.Text.Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}