using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test._fr1Test = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hellworld");
            Form2 fr2 = new Form2();
            fr2.Show();
        }
    }
}
