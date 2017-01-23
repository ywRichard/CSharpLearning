using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace _Timer练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour == 22&&DateTime.Now.Minute == 52&&DateTime.Now.Second == 00)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\Richard\Desktop\dingdong.wav";
                sp.Play();
            }
        }
    }
}
