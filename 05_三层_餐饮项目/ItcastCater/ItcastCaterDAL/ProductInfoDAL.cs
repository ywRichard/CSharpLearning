using System;
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
        /// 通过产品数量或者拼音查询产品信息
        /// </summary>
        /// <param name="num">拼音或者数量</param>
        /// <param name="flag">1->拼音; 2->数量</param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfoBySpellNum(string num, int flag)
        {
            var sql = "select * from ProductInfo where DelFlag=0";
            if (flag == 1)//拼音
            {
                sql += " and ProSpell like @ProSpell";
            }
            else if (flag == 2)//v
            {
                sql += " and ProNum like @ProSpell";
            }

            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@ProSpell", "%" + num + "%"));
            var list = new List<ProductInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToProductInfo(dr));
                }
            }

            return list;
        }
        /// <summary>
        /// 查询一个CatId下产品的数量
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object GetProductInfoCountByCatId(int id)
        {
            var sql = "select count(*) from ProductInfo where DelFlag=0 and CatId=" + id;
            return SqliteHelper.ExecuteScalar(sql);
        }
        /// <summary>
        /// 模糊查询产品数量获得产品信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInforByNum(string num)
        {
            var sql = "select * from ProductInfo where DelFlag=0 and ProNum like @ProNum";

            var list = new List<ProductInfo>();
            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("ProNum", "%" + num + "%"));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToProductInfo(dr));
                }
            }

            return list;
        }
        /// <summary>
        /// 通过CatId获取商品信息
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfoByCatId(int catId)
        {
            var sql = "select * from ProductInfo where CatId=" + catId;

            var dt = SqliteHelper.ExecuteTable(sql);
            var proi = new List<ProductInfo>();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    proi.Add(RowToProductInfo(dr));
                }
            }

            return proi;
        }

        /// <summary>
        /// 通过ProductId获取产品信息
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public ProductInfo GetProductInfoById(int proId)
        {
            var sql = "select * from ProductInfo where ProId=" + proId;
            var dt = SqliteHelper.ExecuteTable(sql);
            var proi = new ProductInfo();
            if (dt.Rows.Count > 0)
            {
                proi = RowToProductInfo(dt.Rows[0]);
            }

            return proi;
        }

        /// <summary>
        /// 新增
        /// </summary>
        public int AddProductInfo(ProductInfo proi)
        {
            var sql = "insert into ProductInfo(CatId,ProName,ProCost,ProSpell,ProPrice,ProUnit,Remark,DelFlag,SubTime,ProStock,ProNum,SubBy) values(@CatId,@ProName,@ProCost,@ProSpell,@ProPrice,@ProUnit,@Remark,@DelFlag,@SubTime,@ProStock,@ProNum,@SubBy)";
            return AddAndUpdateProductInfo(1, proi, sql);
        }

        public int UpdateProductInfo(ProductInfo proi)
        {
            var sql = "update ProductInfo set CatId=@CatId,ProName=@ProName,ProCost=@ProCost,ProSpell=@ProSpell,ProPrice=@ProPrice,ProUnit=@ProUnit,Remark=@Remark,ProStock=@ProStock,ProNum=@ProNum where ProId=@ProId";
            return AddAndUpdateProductInfo(2, proi, sql);
        }

        private int AddAndUpdateProductInfo(int temp, ProductInfo proi, string sql)
        {
            #region Initial Parameter
            var list = new List<SQLiteParameter>() {
                new SQLiteParameter("@CatId",proi.CatId),
                new SQLiteParameter("@ProName",proi.ProName),
                new SQLiteParameter("@ProCost",proi.ProCost),
                new SQLiteParameter("@ProSpell",proi.ProSpell),
                new SQLiteParameter("@ProPrice",proi.ProPrice),
                new SQLiteParameter("@ProUnit",proi.ProUnit),
                new SQLiteParameter("@Remark",proi.Remark),
                new SQLiteParameter("@ProStock",proi.ProStock),
                new SQLiteParameter("@ProNum",proi.ProNum),
            };
            #endregion

            if (temp == 1)//新增
            {
                list.Add(new SQLiteParameter("@DelFlag", proi.DelFlag));
                list.Add(new SQLiteParameter("@SubTime", proi.SubTime));
                list.Add(new SQLiteParameter("@SubBy", proi.SubBy));
            }
            else if (temp == 2)//修改
            {
                list.Add(new SQLiteParameter("@ProId", proi.ProId));
            }

            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }

        /// <summary>
        /// 根据Id删除产品信息
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public int DeleteProductInfoById(int proId)
        {
            var sql = "update ProductInfo set DelFlag=1 where ProId=" + proId;
            return SqliteHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获得全部的产品信息
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns></returns>
        public List<ProductInfo> GetAllProductInfoByDelFlag(int delFlag)
        {
            var sql = "select * from ProductInfo where DelFlag=" + delFlag;

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
                CatId = Convert.ToInt32(dr["CatId"]),
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
