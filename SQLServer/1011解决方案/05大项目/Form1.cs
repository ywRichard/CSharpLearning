using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _05大项目
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
            
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student stu = new Student();
                        stu.TSID = Convert.ToInt32(reader["TSID"]);
                        stu.TSName = reader["TSName"].ToString();
                        stu.TSGender = Convert.ToBoolean(reader["TSGender"])?'男':'女';
                        stu.TSAddress = reader["TSAddress"].ToString();
                        stu.TSAge = Convert.ToInt32(reader["TSAge"].ToString());

                        list.Add(stu);
                    }
                }
            }
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = list;
            //dgv.SelectedRows[0].Selected = false;//不能够选择
        }
        public EventHandler evt;
        public MyEventArgs mea = new MyEventArgs();

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowStudentDataUpdate(1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Student stu = new Student();
                stu.TSID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);//ID
                stu.TSName = dgv.SelectedRows[0].Cells[1].Value.ToString();//Name
                stu.TSGender = Convert.ToChar(dgv.SelectedRows[0].Cells[2].Value);//Gender
                stu.TSAddress = dgv.SelectedRows[0].Cells[3].Value.ToString();//Address
                stu.TSAge = Convert.ToInt32(dgv.SelectedRows[0].Cells[4].Value);//Age

                mea.Obj = stu;

                ShowStudentDataUpdate(2);
            }
            else 
            {
                MessageBox.Show("请选中要修改的行");
            }
        }

        public void ShowStudentDataUpdate(int p)
        {
            StudenDataUpdate sdu = new StudenDataUpdate();
            //把方法作为参数进行传递
            this.evt += new EventHandler(sdu.SetText);//注册事件
            //传值
            mea.temp = p;
            if (this.evt!=null)
            {
                this.evt(this,mea);
            }
            sdu.FormClosed += new FormClosedEventHandler(sdu_FormClosed);
            sdu.Show();
        }

        void sdu_FormClosed(object sender,FormClosedEventArgs e)
        {
            LoadStudent();
        }
    }
}
