using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadStudent()
        {
            DataTable dt = new DataTable();

            var sql = "usp_SelectStudent";//执行存储过程的sql语句,不用加exec
            var str = "";//数据库连接字符串
            using (var sda = new SqlDataAdapter(sql, str))
            {
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = "赵小黑";
            var id = 29;
            var i = 0;
            SqlParameter[] ps = {
                new SqlParameter("@name",name),
                new SqlParameter("@id",id)};
            var str = "";//数据库连接字符串
            using (SqlConnection con=new SqlConnection(str))
            {
                var sql = "usp_updateStudent";//不用加exec
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    cmd.Parameters.AddRange(ps);
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
