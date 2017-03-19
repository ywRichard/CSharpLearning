using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace _02导出数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            using (SqlConnection con = new SqlConnection(str))
            {
                string sql = "select UserID, UserName, UserPwd from UserLogin";
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            using(StreamWriter sw = new StreamWriter("daochu.txt"))
                            {
                                sw.WriteLine("{0},{1},{2}",reader.GetName(0),reader.GetName(1),reader.GetName(2));

                                while(reader.Read())
                                {
                                    sw.WriteLine("{0},{1},{2}",reader[0],reader[1],reader[2]);
                                }//while
                            }//using
                        }// if
                    }// using
                }// using
            }//using 
            Console.WriteLine("操作成功");
            Console.ReadKey();
        }
    }
}
