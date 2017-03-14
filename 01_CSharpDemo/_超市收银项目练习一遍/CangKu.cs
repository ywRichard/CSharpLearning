using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    class CangKu
    {
        //仓库需要有货架存货，进货，出货，显示库存
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        /// <summary>
        /// 建立仓库的同时添加货架
        /// </summary>
        public CangKu()
        {
            for (int i = 0; i < 4; i++)
            {
                list.Add(new List<ProductFather>());//建立了四个货架
            }
        }
        //Acer--list[0]
        //Samsung---list[1]
        //Banana----list[2]
        //JiangYou--list[3]
        //进货：货物的类型，数量。存到货架上。
        //参数--货物的类型，数量
        //方法体---分类存货到货架上
        /// <summary>
        /// 仓库进货
        /// </summary>
        /// <param name="strType">货物名称</param>
        /// <param name="count">货物数量</param>
        public void JinPros(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":list[0].Add(new Acer(Guid.NewGuid().ToString(),3000,"宏碁电脑"));
                        break;
                    case "Samsung": list[1].Add(new Samsung(Guid.NewGuid().ToString(), 5000, "三星手机"));
                        break;
                    case "Banana": list[2].Add(new Banana(Guid.NewGuid().ToString(), 10, "大香蕉"));
                        break;
                    case "JiangYou": list[3].Add(new JiangYou(Guid.NewGuid().ToString(), 5, "老抽酱油"));
                        break;
                    default:
                        break;
                }
            }
        }
        //出货，将货物从货架上拿走，并且返回拿走的类型
        //参数---货物的名称，出货数量。返回值--商品父类数组
        //方法体---将货物拿出，同时将货架上的货物数量减少
        /// <summary>
        /// 出货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">出货数量</param>
        /// <returns>拿出的货物</returns>
        public ProductFather[] QuHuo(string strType,int count)
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

        //显示库存，
        //方法体将货架上的东西遍历一遍显示出来
        /// <summary>
        /// 显示仓库的库存
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("货物的名称{0}，单价是{1}元，库存{2}个", item[0].Name, item[0].Price, item.Count);
            }
        }
    }
}
