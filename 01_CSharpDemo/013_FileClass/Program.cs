using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _013_FileClass
{
    /// <summary>
    /// File类：一次性读取，存入内存 。用于读取小文件，几百K一下的。
    /// </summary>  
    #region File Useful Methods
    //File.Create：创建文件
    //File.AppendAllText：写入文件
    //File.Copy：复制文件
    //File.Delete：删除文件
    //File.Move：剪切文件
    //File.ReadAllBytes：以字节形式读取，读取非文本文件使用。
    //File.ReadAllLines：以行的形式读取文本文件，并返回字符串数组。
    //File.ReadAllText：读取文本文件，返回一个字符串。
    //File.WriteLine();
    //File.Write
    #endregion
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
