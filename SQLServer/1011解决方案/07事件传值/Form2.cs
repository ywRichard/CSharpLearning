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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetText(object Obj, EventArgs e)
        {
            //MyEventArgs mea = e as MyEventArgs;
            //txtForm2.Text = mea.Str;

            MyEventArgs mea = e as MyEventArgs;
            txtForm2.Text = mea.Str;
        }
    }
}
