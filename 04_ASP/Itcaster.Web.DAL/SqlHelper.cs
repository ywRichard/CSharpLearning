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

        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (var con = new SqlConnection(str))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.CommandType = type;
                    if (ps!=null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
