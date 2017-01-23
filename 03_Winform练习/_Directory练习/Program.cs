using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _Directory练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件夹
            //Directory.CreateDirectory(@"C:\Users\Richard\Desktop\new");
            //Directory.CreateDirectory(@"C:\Users\Richard\Desktop\new");
            //string strPath = "";
            //for (int i = 0; i < 99; i++)
            //{
            //    strPath = @"C:\Users\Richard\Desktop\new\" + i;
            //    Directory.CreateDirectory(strPath);
            //}
            //删除一个文件夹
            //Directory.Delete(@"C:\Users\Richard\Desktop\new");
            //Directory.Delete(@"C:\Users\Richard\Desktop\new",true);
            //for (int i = 0; i < 99; i++)
            //{
            //    strPath = @"C:\Users\Richard\Desktop\new" + i;
            //    Directory.Delete(strPath);
            //}
            //剪切文件夹------------抛异常*********
            //Directory.Move(@"C:\a", @"C:\Users\Richard\Desktop\older");
            //获得指定路径下的文件
            //string[] strName = Directory.GetFiles(@"C:\Users\Richard\Desktop\new");
            //for (int i = 0; i < strName.Length; i++)
            //{
            //    Console.WriteLine(strName[i]);
            //}            
            //获得指定路径下的文件夹
            //string[] strDirectory = Directory.GetDirectories(@"C:\Users\Richard\Desktop\new","n*");
            //for (int i = 0; i < strDirectory.Length; i++)
            //{
            //    Console.WriteLine(strDirectory[i]);
            //}
            //判断指定路径下是否存在文件夹
            //if (Directory.Exists(@"C:\Users\Richard\Desktop\new\0"))
            //{
            //    Console.WriteLine("文件夹存在");   
            //}
            //else
            //{
            //    Console.WriteLine("文件夹不存在");
            //}
            Console.WriteLine("操作成功！");
            Console.ReadKey();
        }
    }
}
