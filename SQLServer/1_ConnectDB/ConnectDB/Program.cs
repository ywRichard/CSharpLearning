using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SqlClient;
using System.Data.SqlClient;

namespace ConnectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            //第一遍
            //string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;Integrated Security=True";
            //using (SqlConnection con = new SqlConnection(str))
            //{
            //    con.Open();
            //    string sql = "insert into class values('初中二班','好人')";
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        n = cmd.ExecuteNonQuery();
            //    }
            //}

            ////第二遍
            //string str = "Data Source=127.0.0.1;Initial Catalog = TestDB;Integrated Security=True";
            ////连接数据库
            //using(SqlConnection con = new SqlConnection(str))
            //{
            //    //打开
            //    con.Open();
            //    //执行语句
            //    string sql = "insert into class values('初中一般','假正经')";
            //    //打开数据库
            //    using(SqlCommand cmd = new SqlCommand(sql,con))
            //    {
            //        n = cmd.ExecuteNonQuery();
            //    }
            //}

            ////第三遍
            //string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;Integrated Security=True";
            //using(SqlConnection con = new SqlConnection(str))
            //{
            //    con.Open();
            //    string sql = "insert into class values('初中三班','不是好人')";
            //    using(SqlCommand cmd = new SqlCommand(sql,con))
            //    {
            //        n = cmd.ExecuteNonQuery();
            //    }
            //}

            //第四遍
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            using(SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string sql = "insert into class values('高中5班','也不行')";
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    n = cmd.ExecuteNonQuery();
                }
            }
            if (n > 0)
            {
                Console.WriteLine("添加成功");
            }
            else 
            {
                Console.WriteLine("添加失败");
            }
            Console.ReadKey();
        }
    }
}
