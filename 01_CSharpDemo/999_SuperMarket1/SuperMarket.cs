using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    class SuperMarket
    {
        //先建立一个仓库
        //开店卖东西
        //商品打折
        //给购物小票
        //显示超市的货物
        CangKu ck = new CangKu();
 
        public SuperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("Samsung", 1000);
            ck.JinPros("Banana", 1000);
            ck.JinPros("JiangYou", 1000);
        }

        public void AskBuying()
        {
            Console.WriteLine("请问您要买什么吗？");
            Console.WriteLine("我们这里有Acer,Samsung,Banana,JiangYou");
            string strType = Console.ReadLine();
            Console.WriteLine("需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.QuHuo(strType,count);            
            //计算货物的价钱
            double realMoney = GetMoney(pros);
            Console.WriteLine("你实际应付{0}",realMoney);
            //打折信息
            Console.WriteLine("优惠促销1、不打折；2、打九折；3、打八五折；4、买300送50；5、买500送100");
            string input = Console.ReadLine();
            CalFather cal = CalMoney(input);
            Console.WriteLine("实际应付{0}元", cal.GetPayMoney(realMoney));
            //给出小票的信息
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称：{0}，货物单价：{1}，货物编号：{2}", item.Name, item.Price, item.ID);
            }
        }
        //计算货物的价钱
        //参数：货物的父类
        //返回值：总价
        /// <summary>
        /// 计算货物价格
        /// </summary>
        /// <param name="pros">提取的货物数组</param>
        /// <returns>计算得到的钱</returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        //简单工厂，根据输入的参数，返回一个父类对象。父类对象中装的是子类对象。
        //参数:优惠的选项
        //返回值：打折类的父类
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
                case "4": cal = new CalMN(300, 50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;
                default:
                    break;
            }

            return cal;
        }

        //只有在建立测超市之后，仓库里才有东西。
        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
