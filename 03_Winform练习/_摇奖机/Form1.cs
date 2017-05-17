using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "开始";
            Control.CheckForIllegalCrossThreadCalls = false;//关闭跨线程调用资源的检查
        }

        private bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (false == flag)//停止---开始
            {
                button1.Text = "停止";
                flag = true;
                Thread show = new Thread(PlayGame);
                show.Start();
            }
            else
            {
                button1.Text = "开始";
                flag = false;
            }
        }

        private void PlayGame()
        {
            Random rd = new Random();
            while (flag)
            {
                label1.Text = rd.Next(0, 11).ToString();
                label2.Text = rd.Next(0, 11).ToString();
                label3.Text = rd.Next(0, 11).ToString();
            }
        }
    }
}
