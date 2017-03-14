using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_ForLoop
{
    /// <summary>
    /// 输出99乘法表
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}x{1}={2}\t",i,j,i*j);

            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}x{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
