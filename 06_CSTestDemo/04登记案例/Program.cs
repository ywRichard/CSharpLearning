using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            IDengJi dj = new House();
            dj.DengJi();

            GetDengji(new Car());

            Console.ReadLine();
        }

        public static void GetDengji(IDengJi dj)
        {
            dj.DengJi();
        }
    }
}
