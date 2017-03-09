using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _012_FileStreamRW
{
    /// <summary>
    /// 文件流读写文件，操作大文件
    /// FileStream，操作字节，可操作任何类型的文件。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 读取文件
            //string path = @"C:\Users\SESA435900\Desktop\read.txt";
            //string str="";

            //using (FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
            //{
            //    byte[] txtBuffer = new byte[1024 * 1024 * 5];
            //    int r = fs.Read(txtBuffer, 0, txtBuffer.Length);
            //    str = Encoding.Default.GetString(txtBuffer,0,r);
            //}
            
            //Console.WriteLine(str);
            //Console.ReadLine();
            #endregion

            #region 写文件
            string path = @"C:\Users\SESA435900\Desktop\read.txt";
            string str = "我用了洪荒之力";

            using (FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes(str);

                fsWrite.Write(buffer, 0, buffer.Length);
            }

            Console.WriteLine("写入成功");
            Console.ReadLine();
            #endregion
        }
    }
}
