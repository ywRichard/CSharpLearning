using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _多播委托
{
    class Program
    {
        public delegate void DelT();

        static void Main(string[] args)
        {
            DelT del = T1;
            del += T2;
            del += T3;
            del += T4;
            del();
            Console.ReadKey();
        }

        public static void T1()
        {
            Console.WriteLine("我是T1");
        }

        public static void T2()
        {
            Console.WriteLine("我是T2");
        }

        public static void T3()
        {
            Console.WriteLine("我是T3");
        }

        public static void T4()
        {
            Console.WriteLine("我是T4");
        }
    }
}
