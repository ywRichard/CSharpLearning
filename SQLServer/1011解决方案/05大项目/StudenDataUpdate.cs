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
    public partial class StudenDataUpdate : Form
    {
        public StudenDataUpdate()
        {
            InitializeComponent();
        }
        private int TP { get; set; }

        public void SetText(object sender,EventArgs e)
        {
            MyEventArgs mea = e as MyEventArgs;
            this.TP = mea.temp;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    tb.Text = "";
                }
            }

            if(this.TP == 1)//新增
            {
                
            }
            else if(this.TP==2)//修改
            {
                Student stu = mea.Obj as Student;
                txtAddress.Text = stu.TSAddress;
                txtName.Text = stu.TSName;
                txtAge.Text = stu.TSAge.ToString();
                txtTSID.Text = stu.TSID.ToString();
                rdoMale.Checked = (stu.TSGender == '男') ? true : false;
                rdoFemale.Checked = (stu.TSGender == '女') ? true : false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            int sex = -1;
            stu.TSAddress = txtAddress.Text;
            stu.TSAge = int.Parse(txtAge.Text);
            stu.TSGender = rdoMale.Checked ? '男' : '女';
            stu.TSGender = rdoFemale.Checked ? '男' : '女';
            sex = stu.TSGender == '男' ? 1 : 0;
            stu.TSID = int.Parse(txtTSID.Text);
            stu.TSName = txtName.Text;

            List<SqlParameter> list = new List<SqlParameter>();

            string sql = "";
            SqlParameter[] ps = { 
                                new SqlParameter("@TSID",stu.TSID),
                                new SqlParameter("@TSName",stu.TSName),
                                new SqlParameter("@TSGender",sex),
                                new SqlParameter("@TSAddress",stu.TSAddress),
                                new SqlParameter("@TSAge",stu.TSAge)
                                };

            list.AddRange(ps);

            if (this.TP==1)//新增
            {
                //新增-Sql语句
                sql = "insert into Student (TSID, TSName, TSGender, TSAddress, TSAge) values(@TSID, @TSName, @TSGender, @TSAddress, @TSAge)";
            }
            else if (this.TP==2)//修改
            {
                //修改-Sql语句
                sql = "update Student set TSName=@TSName, TSGender=@TSGender, TSAddress=@TSAddress, TSAge=@TSAge where TSID =@TSID";
            }
            int r = SqlHelper.ExecuteNonQuery(sql, list.ToArray());
            string msg = r > 0 ? "操作成功" : "操作失败";
            MessageBox.Show(msg);
            this.Close();
            
        }
    }
}
