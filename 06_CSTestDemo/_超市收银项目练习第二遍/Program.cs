using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();

            sm.AskBuying();
            sm.ShowPros();

            Console.ReadKey();
        }
    }
}
