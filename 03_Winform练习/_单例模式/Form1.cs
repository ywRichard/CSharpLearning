using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //1、用方法实现单利模式
            //Form2 frm2 = Form2.GetSingle();

            //2、属性实现单例模式
            var frm2 = Form2.Instance;

            //3、非模态对话框
            frm2.Show();

            //4、模态对话框
            //frm2.ShowDialog();
        }
    }
}
