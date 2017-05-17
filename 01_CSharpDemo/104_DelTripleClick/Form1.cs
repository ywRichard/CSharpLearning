using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29_委托的三连击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userThreeClick1._mdl = DoSth;
        }

        public static void DoSth()
        {
            MessageBox.Show("点了三次");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //userThreeClick1._mdl = SaySth;
            userThreeClick1._mdl += SaySth;
        }

        public static void SaySth()
        {
            MessageBox.Show("我被赋值了");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userThreeClick1._mdl();//也可以调用委托，事件不能在外部执行。
        }
    }
}
