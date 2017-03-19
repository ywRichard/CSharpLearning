using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 连接字符串2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = "127.0.0.1";
            //scsb.InitialCatalog = "class";
            //scsb.UserID = "sa";
            //scsb.Password = "123456";

            scsb.DataSource = "127.0.0.1";
            scsb.InitialCatalog = "class";
            scsb.IntegratedSecurity = true;
            Console.WriteLine(scsb.ToString());
            Console.ReadKey();
        }
    }
}
