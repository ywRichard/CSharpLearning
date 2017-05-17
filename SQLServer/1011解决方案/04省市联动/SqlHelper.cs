using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace _04省市联动
{
    public class SqlHelper
    {
        //封装增删改
        private static readonly string str = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="ps">Sql语句中的参数</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        { 
            using(SqlConnection con = new SqlConnection(str))
            {
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    if(ps!=null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }                   
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        //封装查询
        /// <summary>
        /// 查询数据库
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="ps">Sql语句中的参数</param>
        /// <returns>首行首列，object类型</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        { 
            using(SqlConnection con=new SqlConnection(str))
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    if(ps!=null)
                    {
                        cmd.Parameters.AddRange(ps); 
                    }
                    return cmd.ExecuteScalar();
                }                               
            }
        }

        //封装读取
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);

            using(SqlCommand cmd = new SqlCommand(sql,con))
            {
                    
                if(ps!=null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    con.Close();
                    con.Dispose();
                    throw ex;
                }
            }
        }
    }
}
