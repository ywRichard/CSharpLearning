using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _学生老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked == true)
            {
                if (txtName.Text == "student"&&txtPsw.Text == "student")
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                    txtName.Clear();
                    txtPsw.Clear();
                    txtName.Focus();
                }
            }
            else if (rdoTeacher.Checked == true)
            {
                if (txtName.Text=="teacher"&&txtPsw.Text=="teacher")
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                    txtName.Clear();
                    txtPsw.Clear();
                    txtName.Focus();
                }                
            }
        }
    }
}
