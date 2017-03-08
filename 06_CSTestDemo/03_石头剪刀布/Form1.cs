using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03_石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            //Play(btnStone.Text);
            Button btn = (Button)sender;
            Play(btn.Text);
        }

        private void Play( string pFistName)
        {
            Fist player = new Fist();
            player.FistName = pFistName;
            int pNum = player.Play();
            lblPlayer.Text = player.FistName;

            Computer cp = new Computer();
            int cNum = cp.Play();
            lblComputer.Text = cp.FistName;

            Judge judge = new Judge();
            lblResult.Text = judge.Play(pNum, cNum);
        }

        //private void btnScissor_Click(object sender, EventArgs e)
        //{
        //    Play(btnScissor.Text);
        //}

        //private void btnBu_Click(object sender, EventArgs e)
        //{
        //    Play(btnBu.Text);
        //}

    }
}
