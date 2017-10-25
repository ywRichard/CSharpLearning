using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _12_显示学生
{
    class SqlHelper
    {
        private static readonly string str = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        public static DataTable ExecuteTable(string sql, params SqlParameter[] ps)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter sda = new SqlDataAdapter(sql,str))
            {
                sda.Fill(dt);
            }

            return dt;
        }
    }
}
