using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    class CangKu
    {
        //货架，方法：存货，取货，库存
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        /// 建立仓库，添加货架
        /// </summary>
        public CangKu()
        {
            for (int i = 0; i < 4; i++)
            {
                list.Add(new List<ProductFather>());//添加货架
            }
        }
        //list[0]-----Acer
        //list[1]-----Samsung
        //list[2]-----Banana
        //list[3]-----JiangYou
        //将货物（名称，数量）放到仓库中，
        //参数：商品的名称，和数量
        public void JinPros(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(),2000,"弘基电脑"));
                        break;
                    case "Samsung": list[1].Add(new Samsung(Guid.NewGuid().ToString(),4000,"三星手机"));
                        break;
                    case "Banana": list[2].Add(new Banana(Guid.NewGuid().ToString(),50,"大香蕉"));
                        break;
                    case "JiangYou": list[3].Add(new JiangYou(Guid.NewGuid().ToString(),10,"老抽酱油"));
                        break;
                }
            }
        }

        //出货
        //参数，货物的名称，取货的数量
        //返回取走的类型
        public ProductFather[] QuPros(string strType,int count)
        {
            ProductFather[] pros = new ProductFather[count];

            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Samsung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "JiangYou": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            return pros;
        }

        //显示库存
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("名称：{0}，单价：{1}，库存：{2}", item[0].Name, item[1].Price, item.Count);
            }
        }

    }//CangKu
}
