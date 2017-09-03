using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class R_OrderInfo_ProductBLL
    {
        R_OrderInfo_ProductDAL dal = new R_OrderInfo_ProductDAL();

        /// <summary>
        /// 点菜，添加到订单表中
        /// </summary>
        /// <param name="rop"></param>
        /// <returns></returns>
        public bool AddROrderInfoProduct(R_OrderInfo_Product rop)
        {
            return dal.AddROrderInfoProduct(rop) > 0 ? true : false;
        }
        /// <summary>
        /// 通过OrderId,查询获得订单中菜的总价和数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public R_OrderInfo_Product GetAllMoneyAndCount(int orderId)
        {
            return dal.GetAllMoneyAndCount(orderId);
        }
        /// <summary>
        /// 根据订单的Id查询点了什么产品
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public List<R_OrderInfo_Product> GetR_OrderInfo_ProductByOrderId(int orderId)
        {
            return dal.GetROrderInfoProByOrderId(orderId);
        }
    }
}
