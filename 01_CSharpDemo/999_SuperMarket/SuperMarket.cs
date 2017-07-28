using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    class SuperMarket
    {
        ////建立仓库，存入货物
        //CangKu ck = new CangKu();
        ///// <summary>
        ///// 建立仓库存入货物
        ///// </summary>
        //public SuperMarket()
        //{
        //    ck.JinPros("Acer", 1000);
        //    ck.JinPros("Samsung",1000);
        //    ck.JinPros("JianYou", 1000);
        //    ck.JinPros("Banana", 1000);
        //}
        ////用户交互购买
        ///// <summary>
        ///// 
        ///// </summary>
        //public void AskBuying()
        //{
        //    Console.WriteLine("欢迎光临，您需要什么？");
        //    Console.WriteLine("我们这里有Acer,Samsung,JianYou,Banana");
        //    string strType = Console.ReadLine();
        //    Console.WriteLine("需要多少？");
        //    int count = Convert.ToInt32(Console.ReadLine());
        //    ProductFather[] pros = ck.QuPros(strType,count);

        //    double realMoney = GetMoney(pros);
        //}

        ////提货
        
        ////算钱
        //public double GetMoney(ProductFather[] pros)
        //{
        //    double realMoney = 0;
        //    for (int i = 0; i < pros.Length; i++)
        //    {
        //        realMoney += pros[i].Price;
        //    }

        //    return realMoney;
        //}

        //建立仓库
        CangKu ck = new CangKu();

        public SuperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("Samsung",1000);
            ck.JinPros("JianYou", 1000);
            ck.JinPros("Banana", 1000);
        }
        //购买者交互
        public void AskBuying()
        {
            Console.WriteLine("请问您需要什么？");
            Console.WriteLine("我们这有Acer,Samsung,JianYou,Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("请问你要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            ProductFather[] pros = ck.QuPros(strType, count);
            double realMoney = GetMoney(pros);
            Console.WriteLine("总共需要{0}",realMoney);
            Console.WriteLine("请选择您的打折方式1---不打折，2---打九折，3---打85折，4---买300送50，5---买500送100");
            string input = Console.ReadLine();
            //通过简单工厂得到实际应付的钱
            CalFather cal = GetCal(input);
            double payMoney = cal.GetMoney(realMoney);
            Console.WriteLine("打完折后实际应付{0}",payMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称{0}，货物单价{1}，货物编号{2}",item.Name,item.Price,item.ID);
            }            
        }
        //算钱
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300, 50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
