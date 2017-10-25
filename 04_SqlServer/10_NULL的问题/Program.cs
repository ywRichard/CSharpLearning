using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _10_NULL的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            //int num1 = null;

            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            using (SqlConnection con = new SqlConnection(str))
            {
                string sql = "select * from Student";
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //ID, TSID, TSName, TSGender, TSAddress, TSAge
                                Console.WriteLine("{0},{1},{2},{3},{4},{5}", reader["ID"], reader["TSID"], reader["TSName"], reader["TSGender"], reader["TSAddress"], DBNull.Value == reader["TSAge"]?"NULL":reader["TSAge"].ToString());
                                
                            }
                        }   
                    }                
                }
            }

            Console.ReadKey();
            

        }
    }
}
