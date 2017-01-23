using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8计算字符串字符个数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串");
            string str = Console.ReadLine();
            Console.WriteLine("字符串的字符个数是{0}",StringCount(str));
            Console.ReadKey();
        }

        public static int StringCount(string str)
        {
            int num = str.Length;
            return num;
        }
    }
}
