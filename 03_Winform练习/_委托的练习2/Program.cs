using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _委托的练习2
{
    class Program
    {
        public delegate string DelProStr(string name);
        static void Main(string[] args)
        {
            ////三个需求
            ////1、将一个字符串数组中每个元素都转换成大写
            ////2、将一个字符串数组中每个元素都转换成小写
            ////3、将一个字符串数组中每个元素两边都加上 双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            ProStr(names, delegate(string name)
            {
                return "\"" + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }

        public static void ProStr(string[] names,DelProStr prostr)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = prostr(names[i]);
            }
        }
    }
}
