using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace _07_大项目
{
    class SqlHelper
    {
        //封装3个方法
        private static readonly string str = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        public static int ExecuteNonQuery(string sql,params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        { 
            using(SqlConnection con = new SqlConnection(str))
            {
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    if(ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }       
        }

        //public static SqlDataReader ExecuteReader(string sql,params SqlParameter[] ps)
        //{
        //    SqlConnection con = new SqlConnection(str);

        //    using(SqlCommand cmd = new SqlCommand(sql,con))
        //    {
                
        //        if (ps!=null)
        //        {
        //            cmd.Parameters.AddRange(ps);
        //        }
        //        try
        //        {
        //            con.Open();
        //            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //        }
        //        catch(Exception ex)
        //        {
        //            con.Close();
        //            con.Dispose();
        //            throw ex;
        //        }
        //    }
        // }

        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                if (ps != null)
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
