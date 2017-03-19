using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _04注意事项
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
            }
            catch 
            {
                con.Close();
                Console.WriteLine("打开数据库失败");
            }
            
            //Console.WriteLine("哈哈，我打开了");
            //con.Close();
            //Show(con);
            Console.ReadKey();
        }

        private static void Show(SqlConnection con)
        {
            con.Open();
            Console.WriteLine("哈哈，我又打开了");
            con.Close();
        }
    }
}
