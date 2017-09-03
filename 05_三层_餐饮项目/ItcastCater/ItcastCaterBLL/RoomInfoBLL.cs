using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class RoomInfoBLL
    {
        RoomInfoDAL dal = new RoomInfoDAL();

        /// <summary>
        /// 通过删除标识，获取全部房间信息
        /// </summary>
        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            return dal.GetAllRoomInfoByDelFlag(delFlag);
        }
    }
}
