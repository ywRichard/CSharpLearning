using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class DeskInfoBLL
    {
        DeskInfoDAL dal = new DeskInfoDAL();

        /// <summary>
        /// 通过deskId修改餐桌状态
        /// </summary>
        /// <param name="state">1开单,2空闲</param>
        public bool UpdateDeskStateByDeskId(int deskId, int state)
        {
            return dal.UpdateDeskStateByDeskId(deskId, state)>0;
        }

        /// <summary>
        /// 通过房间标识，获取全部餐桌信息
        /// </summary>
        public List<DeskInfo> GetAllDeskInfoByRoomId(int roomId)
        {
            return dal.GetAllDeskInfoByRoomId(roomId);
        }
    }
}
