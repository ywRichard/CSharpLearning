using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    class CangKu
    {
        //储存货物：类型+数量
        //货物进入仓库，在归类到货架上
        List<List<ProductFather>> list = new List<List<ProductFather>>();//将选项归类

        /// <summary>
        /// 在建立仓库的同时，添加货架
        /// </summary>
        public CangKu()
        {
            for (int i = 0; i < 4; i++)
            {
                list.Add(new List<ProductFather>());
            }
        }
        //list[0] Acer
        //list[1] Samsung
        //list[2] 酱油
        //list[3] Banana

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="count">数量</param>
        public void JinPros(string type, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "我是宏碁电脑"));
                        break;
                    case "Samsung": list[1].Add(new Samsung(Guid.NewGuid().ToString(), 500, "我是三星手机"));
                        break;
                    case "JianYou": list[2].Add(new JianYou(Guid.NewGuid().ToString(), 20, "我是酱油"));
                        break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 10000, "我是大香蕉"));
                        break;
                }
            }
        }

        /// <summary>
        /// 提货
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="count">数量</param>
        /// <returns></returns>
        public ProductFather[] QuPros(string type, int count)
        {
            ProductFather[] pros = new ProductFather[count];

            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Samsung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "酱油": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }

        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有{0}，{1}件，价格：{2}元", item[0].Name, item.Count, item[0].Price);
            }
        }

    }
}
