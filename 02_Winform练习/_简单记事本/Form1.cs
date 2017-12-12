using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "yao"&&txtPsw.Text == "123")
            {
                MessageBox.Show("登录成功");
                lblName.Visible = false;
                lalPsw.Visible = false;
                txtName.Visible = false;
                txtPsw.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("登录失败请重新输入密码");
                txtName.Clear();
                txtPsw.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPsw.Clear();
        }

        private void btnWrap_Click(object sender, EventArgs e)
        {
            if (btnWrap.Text == "自动换行")
            {
                btnWrap.Text = "取消自动换行";
                txtConstent.WordWrap = true;
            }
            else if (btnWrap.Text == "取消自动换行")
            {
                btnWrap.Text = "自动换行";
                txtConstent.WordWrap = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"C:\Users\Richard\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txtConstent.Text);
                fs.Write(buffer,0,buffer.Length);
            }

            MessageBox.Show("保存成功");
        }
    }
}
