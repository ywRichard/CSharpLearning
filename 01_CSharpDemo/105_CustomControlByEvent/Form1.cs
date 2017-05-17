using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30_自定义控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userLogin1._evt += new EventHandler(userLogin1__evt);
        }

        void userLogin1__evt(object sender, EventArgs e)
        {
            MyEventArgs mevt = e as MyEventArgs;

            if (mevt.Name == "Admin" && mevt.Psw == "123")
            {
                mevt.Flag = true;
            }
        }
    }
}
