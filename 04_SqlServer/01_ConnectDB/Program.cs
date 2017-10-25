using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConnectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
           str = MakeSqlConnectionString();

            InsertEntity(str);

            ReadEntity(str);

            Console.ReadKey();
        }

        private static void ReadEntity(string connectionStr)
        {
            //如果数据库中某列的值是float，小数C#中double
            //关于NULL C#中的null 不一样
            //bit类型的数据在C#中怎么显示--

            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                string sql = "select DeskId, DeskName, DeskNamePinYin, DeskNum frome DeskInfo";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Dispose();//当前的reader这个对象占用了一个连接对象con
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int column = reader.FieldCount;
                                for (int i = 0; i < column; i++)
                                {
                                    reader.GetString(i);
                                }
                                //int index=reader.GetOridinal
                                //reader[1];
                                //reader["DeskName"];
                                //reader.GetInt32(0);
                                //string name = reader.GetString(1);
                            }
                        }
                    }
                }
            }
        }

        private static void InsertEntity(string connectionStr)
        {
            int n = -1;

            //连接数据库
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                //打开
                con.Open();
                //执行语句
                string sql = "insert into class values('初中一般','假正经')";
                //打开数据库
                using (SqlCommand cmd = new SqlCommand(sql, con))
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
        }

        public static string MakeSqlConnectionString()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = "127.0.0.1";
            //scsb.InitialCatalog = "class";
            //scsb.UserID = "sa";
            //scsb.Password = "123456";

            scsb.DataSource = "127.0.0.1";
            scsb.InitialCatalog = "class";
            scsb.IntegratedSecurity = true;

            return scsb.ToString();
        }
    }
}
