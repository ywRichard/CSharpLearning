using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _016_Random
{
    /// <summary>
    /// 随机数练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                double rNumber = r.Next(1,10);
                Console.WriteLine(rNumber);
            }
            Console.ReadKey();
        }
    }
}
