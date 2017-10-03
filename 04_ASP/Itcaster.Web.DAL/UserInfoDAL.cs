using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itcaster.Web.Model;
using System.Data;
using System.Data.SqlClient;


namespace Itcaster.Web.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 获取所有数据的数目
        /// </summary>
        /// <returns></returns>
        public int GetEntityCount()
        {
            var sql = "select count(*) from UserInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        /// <summary>
        /// 获取指定范围的数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<UserInfo> GetPageEntityList(int start, int end)
        {
            //string sql = "select * from(select row_number() over(order  by id) as num,* from UserInfo) as t where t.num>=@start and t.num<=@end";
            var sql = "select * from (select row_number() over(order by id) as num,* from UserInfo) as t where t.num>=@start and t.num<=@end";
            var ps = new SqlParameter[] {
                new SqlParameter("@start",SqlDbType.Int),
                new SqlParameter("@end",SqlDbType.Int)
            };
            ps[0].Value = start;
            ps[1].Value = end;

            var dt = SqlHelper.GetTable(sql, CommandType.Text, ps);
            var userList = new List<UserInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    userList.Add(RowToUserInfo(dr));
                }
            }
            return userList;
        }

        /// <summary>
        /// Insert a new UserInfo
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int InsertEntityModel(UserInfo userInfo)
        {
            var sql = "insert UserInfo(UserName,UserPass,Email,RegTime) values(@UserName,@UserPass,@Email,@RegTime)";
            var ps = new SqlParameter[] {
                new SqlParameter("@UserName",SqlDbType.NVarChar),
                new SqlParameter("@UserPass",SqlDbType.NVarChar),
                new SqlParameter("@RegTime",SqlDbType.DateTime),
                new SqlParameter("@Email",SqlDbType.NVarChar),
            };
            ps[0].Value = userInfo.UserName;
            ps[1].Value = userInfo.UserPass;
            ps[2].Value = userInfo.RegTime;
            ps[3].Value = userInfo.Email;

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, ps);
        }

        /// <summary>
        /// Edit an UserInfo
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int UpdateEntityModel(UserInfo userInfo)
        {
            var sql = "update UserInfo set UserName=@UserName,UserPass=@UserPass,RegTime=@RegTime,Email=@Email where ID=@ID";

            var ps = new SqlParameter[] {
                new SqlParameter("@UserName",SqlDbType.NVarChar),
                new SqlParameter("@UserPass",SqlDbType.NVarChar),
                new SqlParameter("@RegTime",SqlDbType.DateTime),
                new SqlParameter("@Email",SqlDbType.NVarChar),
                new SqlParameter("@ID",SqlDbType.Int)
            };
            ps[0].Value = userInfo.UserName;
            ps[1].Value = userInfo.UserPass;
            ps[2].Value = userInfo.RegTime;
            ps[3].Value = userInfo.Email;
            ps[4].Value = userInfo.ID;

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, ps);
        }

        /// <summary>
        /// detele an UserInfo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEntityModel(int id)
        {
            var sql = "delete from UserInfo where ID=@ID";
            var ps = new SqlParameter("@ID", SqlDbType.Int);
            ps.Value = id;

            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, ps);
        }

        /// <summary>
        /// Get an UserInfo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetEntityModel(int id)
        {
            var sql = "select * from UserInfo where ID=@ID";
            var ps = new SqlParameter("@ID", SqlDbType.Int);
            ps.Value = id;
            var dt = SqlHelper.GetTable(sql, CommandType.Text, ps);

            var userInfo = new UserInfo();
            if (dt.Rows.Count > 0)
            {
                userInfo = RowToUserInfo(dt.Rows[0]);
            }

            return userInfo;
        }

        /// <summary>
        /// Get all userinfo
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetEntityList()
        {
            string sql = "select * from UserInfo";

            var dt = SqlHelper.GetTable(sql, CommandType.Text);
            var list = new List<UserInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    list.Add(RowToUserInfo(dr));
                }
            }

            return list;
        }

        private UserInfo RowToUserInfo(DataRow dr)
        {
            var userInfo = new UserInfo();

            userInfo.ID = Convert.ToInt32(dr["ID"]);
            userInfo.UserName = dr["UserName"].ToString();
            userInfo.UserPass = dr["UserPass"].ToString();
            userInfo.RegTime = Convert.ToDateTime(dr["RegTime"]);
            userInfo.Email = dr["Email"].ToString();

            return userInfo;
        }

        public UserInfo GetUserInfoModel(string userName)
        {
            string sql = "select * from UserInfo where UserName=@UserName";
            SqlParameter[] pars = {
                                  new SqlParameter("@UserName",userName)

                                  };
            DataTable dt = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo userInfo = null;
            if (dt.Rows.Count > 0)
            {
                userInfo = RowToUserInfo(dt.Rows[0]);
            }
            return userInfo;
        }
    }
}
