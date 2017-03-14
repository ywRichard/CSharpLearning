using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();

            sm.ShowPros();//显示库存
            sm.AskBuying();

            Console.ReadKey();
        }
    }
}
