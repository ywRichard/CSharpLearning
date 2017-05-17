using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _012_FileByStreamRW
{
    /// <summary>
    /// StreamReader & StreamWriter 操作字符串
    /// 只能用于读写文本文件，不能操作多媒体文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //用StreamReader读取文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\Richard\Desktop\Older.txt", Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
                
            //}

            //using (StreamReader sr=new StreamReader(@"C:\Users\Richard\Desktop\Older.txt",Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}
            //Console.ReadKey();

            //用StreamWriter写入文本文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Richard\Desktop\Older.txt",true))//Append为False写入数据时会把原有数据清空
            {
                //sw.WriteLine("看我覆盖了谁？");
                //sw.Write("看我有吧谁给覆盖哈哈哈啊啊？");
                //sw.WriteLine("看我有吧谁给覆盖哈哈哈啊啊？");
            }

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
