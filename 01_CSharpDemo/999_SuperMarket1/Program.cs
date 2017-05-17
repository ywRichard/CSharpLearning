using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立超市
            //开门营业
            SuperMarket sm = new SuperMarket();

            sm.AskBuying();
            sm.ShowPros();

            Console.ReadKey();
        }
    }
}
