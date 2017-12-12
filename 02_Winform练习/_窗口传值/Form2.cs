 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _窗口传值
{
    public delegate void DelShowMsg(string str);

    public partial class Form2 : Form
    {
        DelShowMsg _del;

        public Form2(DelShowMsg del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._del(textBox1.Text);
        }
    }
}
