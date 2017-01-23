using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoYouLoveMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你点到了");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("爱你");
            this.Close();
        }

        private void btnNotLove_MouseEnter(object sender, EventArgs e)
        {
            //获取范围
            int x = this.ClientSize.Width - btnNotLove.Width;
            int y = this.ClientSize.Height - btnNotLove.Height;
            //生成随机坐标
            Random r = new Random();

            btnNotLove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
