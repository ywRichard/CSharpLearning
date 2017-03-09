using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _14_大文件复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathRead = @"C:\Users\SESA435900\Documents\03.基础加强\视频\02集合.avi";
            string pathCopy = @"C:\Users\SESA435900\Desktop\capture\复制.avi";

            using (FileStream fsRead = new FileStream(pathRead, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];//5M

                using (FileStream fsWrite = new FileStream(pathCopy, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    int r = fsRead.Read(buffer, 0, buffer.Length);

                    while (r>0)
                    {
                        fsWrite.Write(buffer, 0, buffer.Length);

                        r = fsRead.Read(buffer, 0, buffer.Length);
                    }
                }

                Console.WriteLine("复制成功");
                Console.ReadLine();
            }
        }
    }
}
