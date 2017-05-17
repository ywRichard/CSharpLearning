using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _05小知识点
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果数据库中某列的值是float，小数C#中double
            //关于NULL C#中的null 不一样
            //bit类型的数据在C#中怎么显示--

            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            using(SqlConnection con = new SqlConnection(str))
            {
                string sql = "select DeskId, DeskName, DeskNamePinYin, DeskNum frome DeskInfo";
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Dispose();//当前的reader这个对象占用了一个连接对象con
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                int column=reader.FieldCount;
                                for(int i = 0;i<column;i++)
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
    }
}
