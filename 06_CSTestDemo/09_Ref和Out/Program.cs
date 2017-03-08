using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_Ref和Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 1000;
            int num =100;
            Add(ref num);
            //Sub(out num);
            Console.WriteLine(num);
            Console.ReadLine();
        }

        //private static void Sub(out int num)
        //{
        //    num = 30;
        //}

        private static void Add(ref int n)
        {
            n = 20;
        }
    }
}
