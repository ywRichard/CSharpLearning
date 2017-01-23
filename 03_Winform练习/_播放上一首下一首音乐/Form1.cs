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

namespace _播放上一首下一首音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //弹出对话框，选择需要播放的文件，导入播放列表
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Richard\Desktop\music";
            ofd.Title = "选择音乐文件";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
                list.Add(path[i]);
            }
            //点击上一首播放
            //点击下一首播放
        }
        SoundPlayer sp = new SoundPlayer();
        List<string> list = new List<string>();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            sp.SoundLocation = list[index];

            sp.Play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index;

            sp.SoundLocation = list[index];
            sp.Play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            if (listBox1.Items.Count == index)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;

            sp.SoundLocation = list[index];
            sp.Play();
        }
    }
}
