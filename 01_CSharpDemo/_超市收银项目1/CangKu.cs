using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目1
{
    class CangKu
    {
        //仓库的功能：存货，进货，提货，实现库存，要求分类放置。
        //存货：货物类型和数量
        List<List<ProductFather>> list = new List<List<ProductFather>>();//货架

        /// <summary>
        /// 建立仓库的同时添加4个货架
        /// </summary>
        public CangKu()
        {
            for (int i = 0; i < 4; i++)
            {
                list.Add(new List<ProductFather>);
            }
        }

        //存货，类型和数量
        public void JinPros(string id,int count)
        {
            for (int i = 0; i < count; i++)
            {
                
            }
        }
    }
}
