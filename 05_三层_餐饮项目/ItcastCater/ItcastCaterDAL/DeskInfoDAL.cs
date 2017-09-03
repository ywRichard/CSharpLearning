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
    public class DeskInfoDAL
    {
        /// <summary>
        /// 通过deskId修改餐桌状态
        /// </summary>
        /// <param name="state">1开单,2空闲</param>
        public int UpdateDeskStateByDeskId(int deskId, int state)
        {
            var sql = "update DeskInfo set DeskState=@DeskState where DelFlag=0 and DeskId=@DeskId";
            return SqliteHelper.ExecuteNonQuery(sql, new SQLiteParameter("@DeskState", state), new SQLiteParameter("@DeskId", deskId));
        }
        /// <summary>
        /// 通过房间标识，获取全部餐桌信息
        /// </summary>
        public List<DeskInfo> GetAllDeskInfoByRoomId(int roomId)
        {
            var sql = "select * from DeskInfo where DelFlag=0 and RoomId=@RoomId";
            var list = new List<DeskInfo>();
            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("RoomId", roomId));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToDeskInfo(dr));
                }
            }

            return list;
        }

        private DeskInfo RowToDeskInfo(DataRow dr)
        {
            var dk = new DeskInfo();
            dk.DeskId = Convert.ToInt32(dr["DeskId"]);
            dk.DeskName = dr["DeskName"].ToString();
            dk.DeskRegion = dr["DeskRegion"].ToString();
            dk.DeskRemark = dr["DeskRemark"].ToString();
            dk.DeskState = Convert.ToInt32(dr["DeskState"]);
            dk.RoomId = Convert.ToInt32(dr["RoomId"]);
            dk.SubBy = Convert.ToInt32(dr["SubBy"]);
            dk.SubTime = Convert.ToDateTime(dr["SubTime"]);

            return dk;
        }
    }
}
