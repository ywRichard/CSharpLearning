using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_ExtensionMethod
{
    public static class StreamUtil
    {
        private const int _bufferSize = 8192;

        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[_bufferSize];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static byte[] ReadFully(this Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                CopyTo(input, tempStream);
                return tempStream.ToArray();
            }
        }
    }
}
