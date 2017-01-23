using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    class SuperMarket
    {
        //需要仓库，进货，卖东西，打折，给收据，看库存
        CangKu ck = new CangKu();

        public SuperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("Samsung", 1000);
            ck.JinPros("Banana", 1000);
            ck.JinPros("JiangYou", 1000);
        }

        //有仓库了，开始吆喝卖东西了
        public void AskBuying()
        {
            Console.WriteLine("你好欢饮光临，请问你需要点什么？");
            Console.WriteLine("我们这里有Acer,Samsung,Banana,JiangYou");
            string strType = Console.ReadLine();
            Console.WriteLine("你要多少个");
            int count = Convert.ToInt32(Console.ReadLine());
            //取货给客户
            ProductFather[] pros = ck.QuPros(strType,count);
            //算钱
            double realMoney = GetMoney(pros);
            Console.WriteLine("总共：{0}元",realMoney);
            //打折优惠
            if (realMoney>3000)
            {
                Console.WriteLine("总价超过了3000，可以享受打折优惠");
                Console.WriteLine("优惠类型：1、不打折；2、打九折；3、打八五折；4、满3000送500；5、满5000送1000");
            }
            string input = Console.ReadLine();
            CalFather cal = CalMoney(input);
            Console.WriteLine("您实际应付{0}元",cal.PayMoney(realMoney));
            //购物小票
            Console.WriteLine("以下是您的购物小票");
            foreach (var item in pros)
            {
                Console.WriteLine("你购买的货物名称{0}，单价{1}，编号{2}",item.Name,item.Price,item.ID);
            }            
        }

        //计算客户总共需要支付多少钱
        //参数商品的类型（父类数组）
        //返回值：总价
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        //通过输入选项，得到打折后的钱。
        //打折类型多样，父类不知道如何实现
        //用简单工厂，输入一个参数得到一个父类，里面装着子类
        public CalFather CalMoney(string input)
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
                case "4": cal = new CalMN(3000, 500);
                    break;
                case "5": cal = new CalMN(5000, 1000);
                    break;
                default:
                    break;
            }
            return cal;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }//SuperMarket
}
