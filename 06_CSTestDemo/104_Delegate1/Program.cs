using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_委托
{
    class Program
    {
        public delegate int MyDel(int num1, int num2);

        static void Main(string[] args)
        {
            int sum = Show(Add, 2, 3);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static int Show(MyDel mdl, int n1, int n2)
        {
            return mdl(n1, n2);
        }

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
