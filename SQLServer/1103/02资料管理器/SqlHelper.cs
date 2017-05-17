using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace _02资料管理器
{
    class SqlHelper
    {
        #region MyRegion
        //private static readonly string str = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        ////增删改
        //public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        //{
        //    using (SqlConnection con = new SqlConnection(str))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql,con))
        //        {
        //            if (ps!=null)
        //            {
        //                cmd.Parameters.AddRange(ps);
        //            }
        //            con.Open();
        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
        ////读取
        //public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        //{
        //    using (SqlConnection con = new SqlConnection(str))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql, con))
        //        {
        //            if (ps!=null)
        //            {
        //                cmd.Parameters.AddRange(ps);
        //            }
        //            try
        //            {
        //                con.Open();
        //                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                con.Dispose();
        //                throw ex;
        //            }
        //        }
        //    }
        //}

        ////返回首行首列
        //public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        //{
        //    using(SqlConnection con = new SqlConnection(str))
        //    {
        //        using(SqlCommand cmd =  new SqlCommand(sql,con))
        //        {
        //            if (ps!=null)
        //            {
        //                cmd.Parameters.AddRange(ps);
        //            }
        //            con.Open();
        //            return cmd.ExecuteScalar();
        //        }		 
        //    }
        //} 
        #endregion

        private static readonly string str = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        //增删改
        public static int ExecuteNonQuery(string sql, SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    if (ps!=null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //首行首列
        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    if (ps!=null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //查询结果
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (ps!=null)
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
