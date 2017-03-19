using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07事件传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public event EventHandler evt;//先声明事件句柄

        public event EventHandler evt;

        private void btnForm2_Click(object sender, EventArgs e)
        {
            ////利用事件传送数值
            //Form2 fr2 = new Form2();
            //MyEventArgs mea = new MyEventArgs();
            //mea.Str = txtForm1.Text;

            ////注册事件
            //this.evt+=new EventHandler(fr2.SetText);
            //if (this.evt!=null)
            //{
            //    this.evt(this, mea);
            //}
            //fr2.Show();

            Form2 frm2 = new Form2();
            MyEventArgs mea = new MyEventArgs();
            mea.Str = txtForm1.Text;
            //注册事件
            this.evt+=new EventHandler(frm2.SetText);
            if (this.evt!=null)
            {
                this.evt(this,mea);
            }
            frm2.Show();

        }
    }
}
