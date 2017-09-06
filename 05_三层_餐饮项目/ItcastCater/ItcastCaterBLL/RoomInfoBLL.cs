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
        /// 通过RoomId删除房间
        /// </summary>
        public bool DeleteRoomInfoByRoomId(int id)
        {
            return dal.DeleteRoomInfoByRoomId(id) > 0 ? true : false;
        }

        /// <summary>
        /// 新增或者修改房间信息
        /// </summary>
        /// <returns></returns>
        public bool SaveRoomInfo(RoomInfo ri, int flag)
        {
            int r = -1;
            if (flag == 1)
            {
                r = dal.AddRoomInfo(ri);
            }
            else if (flag == 2)
            {
                r = dal.UpdateRoomInfo(ri);
            }

            return r > 0;
        }
        /// <summary>
        /// 通过删除标识，获取全部房间信息
        /// </summary>
        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            return dal.GetAllRoomInfoByDelFlag(delFlag);
        }
    }
}
