using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class OrderInfoBLL
    {
        OrderInfoDAL dal = new OrderInfoDAL();

        /// <summary>
        /// 通过OrderId查询订单金额
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public decimal GetMoneyByOrderId(int orderId)
        {
            var result = dal.GetMoneyByOrderId(orderId);

            return dal.GetMoneyByOrderId(orderId) != DBNull.Value ? Convert.ToDecimal(dal.GetMoneyByOrderId(orderId)) : -1;
        }
        /// <summary>
        /// 通过OrderId保存订单总消费
        /// </summary>
        public bool UpdateMoneyByOrderId(int orderId, int money)
        {
            return dal.UpdateMoneyByOrderId(orderId, money) > 0 ? true : false;
        }
        /// <summary>
        /// 通过餐桌id获得OrderInfo的id
        /// </summary>
        /// <param name="deskId"></param>
        /// <returns>OrderId</returns>
        public int GetOrderIdByDeskId(int deskId)
        {
            return Convert.ToInt32(dal.GetOrderIdByDeskId(deskId));
        }
        /// <summary>
        /// 添加一个新订单
        /// </summary>
        public int AddOrderInfo(OrderInfo order)
        {
            return Convert.ToInt32(dal.AddOrderInfo(order));
        }
    }
}
