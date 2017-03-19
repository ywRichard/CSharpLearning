using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _05大项目01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void LoadStudent()
        {
            List<Student> list = new List<Student>();
            string sql = "select TSID,TSName,TSGender,TSAddress,TSAge from Student";

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student stu = new Student();

                        stu.TSID = Convert.ToInt32(reader["TSID"]);
                        stu.TSName = reader["TSName"].ToString();
                        stu.TSGender = Convert.ToBoolean(reader["TSGender"]) ? '男' : '女';
                        stu.TSAddress = reader["TSAddress"].ToString();
                        stu.TSAge = Convert.ToInt32(reader["TSAge"]);

                        list.Add(stu);
                    }
                }
            }
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = list;
            //dgv.SelectedRows[0].Selected = false;//不能够选择
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //新增
            StudentUpdate(1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //修改
            StudentUpdate(2);
        }

        public void StudentUpdate(int p)
        {
            Form2 stuDialog = new Form2();
            stu.SetText(p,);

            stuDialog.Show();
        }
    }
}
