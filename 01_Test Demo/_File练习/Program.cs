using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _File练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Richard\Desktop\Older.txt";//文件的绝对路径
            //File类---写入
            //File.WriteAllLines(path, new string[] { "张三", "李四", "王五" });
            //File.WriteAllText(path, "哈哈哈哈");
            //File.WriteAllBytes(path,
            //File.AppendAllLines(path,new string[] {"张三", "李四", "王五"});
            //File.AppendAllText(path, "呵呵呵");

            //string[] contents = File.ReadAllLines(path);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    Console.WriteLine(contents[i]);
            //}

            //File类---读取
            //string contents = File.ReadAllText(path);
            //string contents = File.ReadAllText(path, Encoding.ASCII);
            //byte[] buffer = File.ReadAllBytes(path);
            //string contents = Encoding.GetEncoding("GBK").GetString(buffer);
            //string contents = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(contents);
            Console.ReadKey();
        }
    }
}
