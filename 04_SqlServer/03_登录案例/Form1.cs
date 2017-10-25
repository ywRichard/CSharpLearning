using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03_登录案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=TestDB;User ID=sa;Password=123456";

            object obj;
            using (SqlConnection con = new SqlConnection(str))
            {
                //string sql = string.Format("select count(*) from UserLogin where UserName='{0}' and UserPwd='{1}'", txtAccount.Text, txtPassword.Text);
                string sql = "select count(*) from UserLogin where UserName=@name and UserPwd=@pwd";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    //using(SqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    if(reader.HasRows)
                    //    {
                    //        reader.GetString("");
                    //    }
                    //}
                    cmd.Parameters.AddWithValue("@name", txtAccount.Text);
                    cmd.Parameters.AddWithValue("@pwd",txtPassword.Text);
                    obj = cmd.ExecuteScalar();
                }

                if (Convert.ToInt32(obj) > 0)
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }
    }
}
