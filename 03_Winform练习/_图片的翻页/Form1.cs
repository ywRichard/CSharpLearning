using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _图片的翻页
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            picBox.Image = Image.FromFile(@"C:\Users\Richard\Desktop\picture\1.jpg");
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        int _index = 0;

        string[] path = Directory.GetFiles(@"C:\Users\Richard\Desktop\picture");

        private void btnNext_Click(object sender, EventArgs e)
        {
            _index++;
            if (_index == path.Length)
            {
                _index = 0;
            }
            picBox.Image = Image.FromFile(path[_index]);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            _index--;
            if (_index<0)
            {
                _index = path.Length - 1;
            }
            picBox.Image = Image.FromFile(path[_index]);
        }
    }
}
