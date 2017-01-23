using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11接受用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit;
            Console.WriteLine("你喜欢吃什么水果？");
            //Console.ReadKey();
            fruit = Console.ReadLine();
            Console.WriteLine("我也喜欢吃{0}",fruit);
            Console.ReadKey();
        }
    }
}
