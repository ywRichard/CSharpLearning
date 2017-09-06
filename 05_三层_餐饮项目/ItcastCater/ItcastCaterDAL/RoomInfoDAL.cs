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
        /// 通过RoomId删除房间
        /// </summary>
        public int DeleteRoomInfoByRoomId(int id)
        {
            var sql = "update RoomInfo set Delflag=1 where RoomId=" + id;
            return SqliteHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 新增Room
        /// </summary>
        /// <param name="ri"></param>
        /// <returns></returns>
        public int AddRoomInfo(RoomInfo ri)
        {
            var sql = "insert into RoomInfo(RoomName,RoomType,RoomMinimunConsume,RoomMaxConsumer,IsDefault,DelFlag,SubTime,SubBy) values(@RoomName,@RoomType,@RoomMinimunConsume,@RoomMaxConsumer,@IsDefault,@DelFlag,@SubTime,@SubBy)";
            var ps = new SQLiteParameter[] {
                new SQLiteParameter("@RoomName",ri.RoomName),
                new SQLiteParameter("@RoomType",ri.RoomType),
                new SQLiteParameter("@RoomMinimunConsume",ri.RoomMinimunConsume),
                new SQLiteParameter("@RoomMaxConsumer",ri.RoomMaxConsumer),
                new SQLiteParameter("@IsDefault",ri.IsDefault),
                new SQLiteParameter("@DelFlag",ri.DelFlag),
                new SQLiteParameter("@SubTime",ri.SubTime),
                new SQLiteParameter("@SubBy",ri.SubBy),
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 修改Room
        /// </summary>
        /// <param name="ri"></param>
        /// <returns></returns>
        public int UpdateRoomInfo(RoomInfo ri)
        {
            var sql = "update RoomInfo set RoomName=@RoomName,RoomType=@RoomType,RoomMinimunConsume=@RoomMinimunConsume,RoomMaxConsumer=@RoomMaxConsumer,IsDefault=@IsDefault where DelFlag=0 and RoomId=@RoomId";
            var ps = new SQLiteParameter[]
            {
                new SQLiteParameter("@RoomName",ri.RoomName),
                new SQLiteParameter("@RoomType",ri.RoomType),
                new SQLiteParameter("@RoomMinimunConsume",ri.RoomMinimunConsume),
                new SQLiteParameter("@RoomMaxConsumer",ri.RoomMaxConsumer),
                new SQLiteParameter("@IsDefault",ri.IsDefault),
                new SQLiteParameter("@RoomId",ri.RoomId)
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 通过删除标识，获取全部房间信息
        /// </summary>
        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            var sql = "select * from RoomInfo where DelFlag=" + delFlag;
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
