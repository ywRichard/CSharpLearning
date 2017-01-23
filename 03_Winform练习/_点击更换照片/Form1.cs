using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _点击更换照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\Richard\Desktop\picture");
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(path[i]);
                list.Add(path[i]);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(list[index]);
        }
    }
}
