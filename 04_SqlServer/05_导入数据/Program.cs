using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace _05_导入数据
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一遍
            //string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            //using(StreamReader read = new StreamReader("daochu.txt"))
            //{
            //    string line = read.ReadLine();
            //    using (SqlConnection con = new SqlConnection(str))
            //    {
            //        con.Open();
            //        string sql = "insert into UserLogin values(@UserName,@UserPwd)";
            //        SqlParameter[] ps = { 
            //                                new SqlParameter("@UserName",System.Data.SqlDbType.NVarChar),
            //                                new SqlParameter("@UserPwd",System.Data.SqlDbType.NVarChar)
            //                            };

            //        using(SqlCommand cmd = new SqlCommand(sql,con))
            //        {
            //            cmd.Parameters.AddRange(ps);

            //            while((line = read.ReadLine())!=null)
            //            {
            //                string[] txts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //                ps[0].Value = txts[1];
            //                ps[1].Value = txts[2];

            //                cmd.ExecuteNonQuery();
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("导入成功");
            //Console.ReadKey(); 
            #endregion
            //第二遍
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            
            using (StreamReader read = new StreamReader("daochu.txt"))
            {
                string line = read.ReadLine();
                using(SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string sql = "insert into UserLogin values(@UserName,@UserPwd)";
                    SqlParameter[] ps = { 
                                            new SqlParameter("@UserName",System.Data.SqlDbType.NVarChar),
                                            new SqlParameter("@UserPwd",System.Data.SqlDbType.NVarChar)
                                        };
                    using(SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.AddRange(ps);
                        while((line = read.ReadLine())!=null)
                        {
                            string[] txts = line.Split(new char[] { ',' }, StringSplitOptions.None);
                            ps[0].Value = txts[1];
                            ps[1].Value = txts[2];

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            Console.WriteLine("导入成功");
            Console.ReadKey();

        }
    }
}
