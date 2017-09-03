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
        /// 添加一个新订单
        /// </summary>
        public int AddOrderInfo(OrderInfo order)
        {
            return Convert.ToInt32(dal.AddOrderInfo(order));
        }
    }
}
