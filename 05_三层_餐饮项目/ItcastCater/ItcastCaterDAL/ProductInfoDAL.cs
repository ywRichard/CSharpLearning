﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ItcastCater.Model;

namespace ItcastCater.DAL
{

    public class ProductInfoDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        public int AddProductInfo(ProductInfo proi)
        {
            var sql = "insert into ProductInfo(CatId,ProName,ProCost,ProSpell,ProPrice,ProUnite,Rmark,DelFlag,SubTime,ProStock,ProNum) values(@CatId,@ProName,@ProCost,@ProSpell,@ProPrice,@ProUnite,@Rmark,DelFlag,@SubTime,@ProStock,@ProNum)";
            return AddAndUpdateProductInfo(1, proi, sql);
        }

        public int UpdateProductInfo(ProductInfo proi)
        {
            var sql = "update ProductInfo set ProName=@ProName,ProCost=@ProCost,ProSpell=@ProSpell,ProPrice=@ProPrice,ProUnite=@ProUnite,Rmark=@Rmark,DelFlag=@DelFlag,SubTime=@SubTime,ProStock=@ProStock,ProNum=@ProNum where ProId=@ProId";
            return AddAndUpdateProductInfo(1, proi, sql);
        }

        private int AddAndUpdateProductInfo(int temp, ProductInfo proi, string sql)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获得全部的产品信息
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns></returns>
        public List<ProductInfo> GetAllProductInfo(int delFlag)
        {
            var sql = "select * from ProductInfo where delFlag=" + delFlag;

            var list = new List<ProductInfo>();
            var dt = SqliteHelper.ExecuteTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToProductInfo(dr));
                }
            }

            return list;
        }

        private ProductInfo RowToProductInfo(DataRow dr)
        {
            var pi = new ProductInfo
            {
                ProCost = Convert.ToDecimal(dr["ProCost"]),
                ProId = Convert.ToInt32(dr["ProId"]),
                ProName = dr["ProName"].ToString(),
                ProNum = dr["ProNum"].ToString(),
                ProPrice = Convert.ToDecimal(dr["ProPrice"]),
                ProSpell = dr["ProSpell"].ToString(),
                ProStock = Convert.ToDecimal(dr["ProStock"]),
                ProUnit = dr["ProUnit"].ToString(),
                Remark = dr["Remark"].ToString()
            };

            return pi;
        }
    }
}
