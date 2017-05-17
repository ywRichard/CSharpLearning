using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace _双击播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\Richard\Desktop\music");
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(path[i]);
                listMusic.Add(path[i]);
            }
        }

        List<string> listMusic = new List<string>();

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {            
            SoundPlayer sp = new SoundPlayer(listMusic[listBox1.SelectedIndex]);
            sp.Play();
        }
    }
}
