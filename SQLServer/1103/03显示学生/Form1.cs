using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03显示学生
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 第一次
            //表
            //DataTable dt = new DataTable();

            //string sql = "select * from Student";
            //string strCon = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";
            //using (SqlDataAdapter sda = new SqlDataAdapter(sql,strCon))
            //{
            //    //把数据直接放到表中--填充到表中
            //    sda.Fill(dt);
            //}

            //dgv.DataSource = dt; 
            #endregion

            //第二次
            //DataTable dt = new DataTable();
            //string sql = "select * from student";
            //string strCon = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";

            //using (SqlDataAdapter sda = new SqlDataAdapter(sql,strCon))
            //{
            //    sda.Fill(dt);
            //}

            //dgv.DataSource = dt;

            //第三次
            dgv.DataSource = SqlHelper.ExecuteTable("select * from Student");

        }
    }
}
