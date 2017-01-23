using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _石头剪刀布1
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

            CaiPan(str);
        }

        private void CaiPan(string str)
        {
            Player play = new Player();
            int plyNum = play.ShowFist(str);
            lblPlayer.Text = str;

            Computer cpu = new Computer();
            int cpuNum = cpu.ShowFist();
            lblComputer.Text = cpu.Fist;

            Result res = Judger.Judge(plyNum, cpuNum);
            lblJudge.Text = res.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            CaiPan(str);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            string str = "布";
            CaiPan(str);
        }
    }
}
