using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.Model;
using System.Data.SQLite;
using System.Data;

namespace ItcastCater.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 在数据库中查询账号
        /// </summary>
        /// <param name="loginName">账号</param>
        /// <returns>返回的UserInfo的对象</returns>
        public UserInfo IsLoginByName(string loginName)
        {
            var sql = "select * from UserInfo where LoginUserName=@LoginUserName";
            DataTable dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@LoginUserName", loginName));
            UserInfo user = null;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    user = RowToUserInfo(dr);
                }
            }

            return user;
        }

        private UserInfo RowToUserInfo(DataRow dr)
        {
            UserInfo user = new UserInfo();
            user.DelFlag = Convert.ToInt32(dr["DelFlag"]);
            user.LastLoginIP = dr["LastLoginIP"].ToString();
            user.LastLoginTime = Convert.ToDateTime(dr["LastLoginTime"]);
            user.LoginUserName = dr["LoginUserName"].ToString();
            user.Pwd = dr["Pwd"].ToString();
            user.SubTime = Convert.ToDateTime(dr["SubTime"]);
            user.UserId = Convert.ToInt32(dr["UserId"]);
            user.UserName = dr["UserName"].ToString();

            return user;
        }
    }
}
