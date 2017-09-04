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
    public class R_OrderInfo_ProductDAL
    {
        /// <summary>
        /// 退菜
        /// </summary>
        /// <param name="rOrderId"></param>
        /// <returns></returns>
        public int DeleteROrderProductById(int rOrderId)
        {
            var sql = "update R_OrderInfo_Product set DelFlag=1 where ROrderProId=@ROrderProId";
            return SqliteHelper.ExecuteNonQuery(sql, new SQLiteParameter("@ROrderProId", rOrderId));
        }
        /// <summary>
        /// 点菜，添加到订单表中
        /// </summary>
        /// <param name="rop"></param>
        /// <returns></returns>
        public int AddROrderInfoProduct(R_OrderInfo_Product rop)
        {
            var sql = "insert into R_OrderInfo_Product(OrderId,ProId,DelFlag,SubTime,State,UnitCount) values(@OrderId,@ProId,@DelFlag,@SubTime,@State,@UnitCount)";
            var ps = new SQLiteParameter[] {
                new SQLiteParameter("@OrderId",rop.OrderId),
                new SQLiteParameter("@ProId",rop.ProId),
                new SQLiteParameter("@DelFlag",rop.DelFlag),
                new SQLiteParameter("@SubTime",rop.SubTime),
                new SQLiteParameter("@State",rop.State),
                new SQLiteParameter("@UnitCount",rop.UnitCount)
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        /// <summary>
        /// 通过OrderId,查询获得订单中菜的总价和数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public R_OrderInfo_Product GetAllMoneyAndCount(int orderId)
        {
            var sql = "select count(*),sum(ProPrice*UnitCount) from R_OrderInfo_Product inner join ProductInfo on ProductInfo.ProId=R_OrderInfo_Product.ProId where OrderId = @OrderId and R_OrderInfo_Product.DelFlag = 0";

            R_OrderInfo_Product rop = null;
            using (SQLiteDataReader reader = SqliteHelper.ExecuteReader(sql, new SQLiteParameter("@OrderId", orderId)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rop = new R_OrderInfo_Product();
                        rop.CT = Convert.ToInt32(reader[0]);

                        if (DBNull.Value == reader[1])
                        {
                            rop.MONEY = 0;
                        }
                        else
                        {
                            rop.MONEY = Convert.ToDecimal(reader[1]);
                        }
                    }
                }
            }

            return rop;
        }
        /// <summary>
        /// 根据订单的Id查询点了什么产品
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public List<R_OrderInfo_Product> GetROrderInfoProByOrderId(int orderId)
        {
            var sql = "select ROrderProId,ProName,ProPrice,UnitCount,ProUnit,CatName,R_OrderInfo_Product.SubTime from R_OrderInfo_Product inner join ProductInfo on ProductInfo.ProId = R_OrderInfo_Product.ProId inner join CategoryInfo on ProductInfo.CatId = CategoryInfo.CatId where OrderId = @OrderId and R_OrderInfo_Product.DelFlag = 0";

            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@OrderId", orderId));
            var list = new List<R_OrderInfo_Product>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToROrderInfo(dr));
                }
            }

            return list;
        }

        private R_OrderInfo_Product RowToROrderInfo(DataRow dr)
        {
            var rop = new R_OrderInfo_Product
            {
                CatName = dr["CatName"].ToString(),
                ProName = dr["ProName"].ToString(),
                ProPrice = Convert.ToDecimal(dr["ProPrice"]),
                ProUnit = dr["ProUnit"].ToString(),
                UnitCount = Convert.ToDecimal(dr["UnitCount"]),
                SubTime = Convert.ToDateTime(dr["SubTime"]),
                ROrderProId = Convert.ToInt32(dr["ROrderProId"])
            };
            rop.ProMoney = rop.ProPrice * rop.UnitCount;

            return rop;
        }
    }
}
