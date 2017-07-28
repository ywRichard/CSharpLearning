using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _25_委托之窗体传值
{
    public partial class Form2 : Form
    {
        public delegate void MyDel(string str);

        private MyDel _mdl;

        public MyDel Mdl
        {
            get { return _mdl; }
            set { _mdl = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string str,MyDel mdl): this()
        {
            textBox1.Text = str;
            this.Mdl = mdl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Mdl(textBox1.Text);
        }
    }
}
