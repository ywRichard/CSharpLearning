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
    public class RoomInfoDAL
    {
        /// <summary>
        /// 通过删除标识，获取全部房间信息
        /// </summary>
        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            var sql = "select * from RoomInfo where DelFlag="+ delFlag;
            var list = new List<RoomInfo>();
            var dt = SqliteHelper.ExecuteTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToRoomInfo(dr));
                }
            }

            return list;
        }

        private RoomInfo RowToRoomInfo(DataRow dr)
        {
            var rm = new RoomInfo();
            rm.IsDefault = Convert.ToInt32(dr["IsDefault"]);
            rm.RoomId = Convert.ToInt32(dr["RoomId"]);
            rm.RoomMaxConsumer = Convert.ToDecimal(dr["RoomMaxConsumer"]);
            rm.RoomMinimunConsume = Convert.ToDecimal(dr["RoomMinimunConsume"]);
            rm.RoomName = dr["RoomName"].ToString();
            rm.RoomType = Convert.ToInt32(dr["RoomType"]);
            rm.SubBy = Convert.ToInt32(dr["SubBy"]);
            rm.SubTime = Convert.ToDateTime(dr["SubTime"]);
            return rm;
        }
    }
}
