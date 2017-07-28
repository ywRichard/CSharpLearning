using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24_委托改变字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "qwe", "asd", "zxc", "fgh" };

            ChangeString cs = new ChangeString();
            cs.ChangeStr(names,AddDrama);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }

        public static string ToUpper(string str)
        {
            return str = str.ToUpper();
        }

        public static string AddDrama(string str)
        {
            return str = "+++" + str + "---";
        }
    }
}
