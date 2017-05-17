using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _004_stringExes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Richard\Desktop\新建文本文档.txt";
            string[] contents= File.ReadAllLines(path,Encoding.Default);
            //string[] strContent = new string[2];
            string showContents;
            char[] chs = {'\t'};
            for (int i = 0; i < contents.Length; i++)
            {
                string[] strContent = contents[i].Split(chs, StringSplitOptions.RemoveEmptyEntries);
                if (strContent[0].Length >= 10)
                {
                    showContents = strContent[0].Substring(0, 8);
                    showContents += "...";
                }
                else 
                {
                    showContents = strContent[0];
                }
                showContents= showContents+"-"+strContent[1];
                Console.WriteLine(showContents);
            }
            Console.ReadKey();
        }
    }
}
