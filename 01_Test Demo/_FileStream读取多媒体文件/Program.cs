using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _FileStream读取多媒体文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Richard\Desktop\《七龙珠Z》133.mkv";
            string target = @"C:\Users\Richard\Desktop\new.mkv";
            CopyFile(source, target);
            Console.WriteLine("写入成功");
            Console.ReadKey();

        }

        public static void CopyFile(string source, string target)
        {
            #region 多媒体复制
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (0 == r)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                }
            } 
            #endregion
            //读取文件
            using(FileStream fsRead = new FileStream(source,FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                using(FileStream fsWrite=new FileStream(target,FileMode.OpenOrCreate,FileAccess.Write))
                {
                    
                    while (true)
                    {
                        int r = fsRead.Read(buffer,0,buffer.Length);
                        if (0==r)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                }
            }

        }
    }
}
