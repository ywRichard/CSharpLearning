using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace _04临时数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建数据库
            DataSet ds = new DataSet("MyDatabase");
            //创建表
            DataTable dt = new DataTable("student");
            //创建列
            DataColumn dc1 = new DataColumn("stuId", typeof(int));
            DataColumn dc2 = new DataColumn("stuName",typeof(string));
      
            //添加列
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            //添加数据
            dt.Rows.Add(1, "xiaoming");
            dt.Rows.Add(2, "Lucy");
            //添加报表
            ds.Tables.Add(dt);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine("{0},{1}",row["stuId"],row["stuName"]);
                }
            }
            Console.ReadKey();
        }
    }
}
