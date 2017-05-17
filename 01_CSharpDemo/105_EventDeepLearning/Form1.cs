using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30_事件的三连击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void evenThrClick1_Load(object sender, EventArgs e)
        {
            
        }

        public static void MyShow()
        {
            MessageBox.Show("I'm here.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            utc._met += MyShow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utc._met += btn_Show;
        }

        public static void btn_Show()
        {
            MessageBox.Show("This is event from button 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utc._met -= btn_Show;
        }
    }
}
