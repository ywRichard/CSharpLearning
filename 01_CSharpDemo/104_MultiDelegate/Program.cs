using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_委托之多播委托
{
    class Program
    {
        public delegate void MyDel();
        static void Main(string[] args)
        {
            MyDel md = M1;
            md += M2;
            md += M3;
            md += M4;
            md -= M2;
            //Delegate.Combine();
            md();//多播委托，可进行简单迭代

            Console.ReadLine();
        }

        public static void M1()
        {
            Console.WriteLine("1");
        }

        public static void M2()
        {
            Console.WriteLine("2");
        }

        public static void M3()
        {
            Console.WriteLine("3");
        }

        public static void M4()
        {
            Console.WriteLine("4");
        }
    }
}
