using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace _06_CompressFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string to compress (will be repeated 100 times):");
                var source = Console.ReadLine();

                StringBuilder sb = new StringBuilder(source.Length * 100);
                for (int i = 0; i < 100; i++)
                {
                    sb.Append(source);
                }
                source = sb.ToString();
                Console.WriteLine("Source data is {0} bytes long.", source.Length);

                var fileName = "compressFile.txt";
                SaveCompressedFile(fileName, source);
                Console.WriteLine("\nData saved to {0}.", fileName);

                FileInfo compressedFile = new FileInfo(fileName);
                Console.WriteLine("Compressed file is {0} bytes long", compressedFile.Length);

                var recoveredString = LoadCompressedFile(fileName);
                recoveredString = recoveredString.Substring(0, recoveredString.Length / 100);

                Console.WriteLine("\nRecovered Data: {0}", recoveredString);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception throw");
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// 压缩文件
        /// GZipStream & DeflateStream工作方式相同
        /// </summary>
        static void SaveCompressedFile(string fileName, string data)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Compress);

            using (StreamWriter sw = new StreamWriter(compressionStream))
            {
                sw.Write(data);
            }
        }

        /// <summary>
        /// 解压文件
        /// </summary>
        static string LoadCompressedFile(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Decompress);
                StreamReader sr = new StreamReader(compressionStream);
                return sr.ReadToEnd();
            }
            //sr.Close();
        }
    }
}
