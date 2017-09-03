using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.Model;
using ItcastCater.DAL;

namespace ItcastCater.BLL
{
   public class R_Order_DeskBLL
    {
        R_Order_DeskDAL dal = new R_Order_DeskDAL();

        /// <summary>
        /// 添加一个中间表的数据
        /// </summary>
        public bool AddROrderDesk(R_Order_Desk rod)
        {
            return dal.AddROrderDesk(rod) > 0;
        }
    }
}
