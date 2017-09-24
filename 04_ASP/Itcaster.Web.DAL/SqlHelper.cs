using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Itcaster.Web.DAL
{
    public static class SqlHelper
    {
        private static readonly string str = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 获取一个数据表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (var con = new SqlConnection(str))
            {
                using (var sda = new SqlDataAdapter(sql, con))
                {
                    con.Open();
                    sda.SelectCommand.CommandType = type;
                    if (ps != null)
                    {
                        sda.SelectCommand.Parameters.AddRange(ps);
                    }

                    var dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// 查询受影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (var con = new SqlConnection(str))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.CommandType = type;
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 获取首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (var con = new SqlConnection(str))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.CommandType = type;
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }

                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
