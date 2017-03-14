using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _随机数生成
{
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
