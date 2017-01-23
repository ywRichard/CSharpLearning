using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";

            Process(str);
        }

        private void Process(string str)
        {
            Player player = new Player();
            int plyNum = player.Fist(str);
            lblPlayer.Text = str;

            //Judger judger = new Judger();
            Computer cpu = new Computer();
            int cpuNum = cpu.Fist();
            lblComputer.Text = cpu.strFist;

            Result res = Judger.JudgeFist(plyNum, cpuNum);
            lblJudger.Text = res.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            Process(str);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            string str="布";
            Process(str);
        }
    }
}
