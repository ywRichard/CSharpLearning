using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _002_OOP
{
    /// <summary>
    /// 石头剪刀布案例，学习面向对象的概念。
    /// 如何抽象建立对象，建立玩家，电脑和裁判的类。玩家和电脑各自实现自己的出拳方式，裁判比较玩家和电脑出拳结果，并比较。
    /// 小知识点：剪刀和布的点击事件可以通过石头按钮来实现。
    /// </summary>
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
