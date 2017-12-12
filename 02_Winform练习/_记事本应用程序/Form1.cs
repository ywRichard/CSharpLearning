using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.Multiselect = true;
            ofd.Filter = "文本文件|*.txt|多媒体文件|*.wav|所有文件|*.*";
            ofd.InitialDirectory = @"C:\Users\Richard\Desktop\qwe";
            ofd.ShowDialog();

            string fileName = ofd.FileName;
            if (fileName == "")
            {
                MessageBox.Show("空路径");
            }
            string path = Path.GetFullPath(fileName);//两者都能得到全路径
            listBox1.Items.Add(path);

            using (FileStream fsRead = new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer);                
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\Richard\Desktop";
            sfd.Title = "保存文件";
            sfd.Filter = "文本文件|*.txt|多媒体文件|*.wav|所有文件|*.*";
            
            using (FileStream fsWrite=new FileStream(sfd.FileName,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void 换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (换行ToolStripMenuItem.Text == "☆自动换行")
            {
                textBox1.WordWrap = true;
                换行ToolStripMenuItem.Text = "取消换行";
            }
            else if (换行ToolStripMenuItem.Text == "取消换行")
            {
                textBox1.WordWrap = false;
                换行ToolStripMenuItem.Text = "☆自动换行";
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();

            textBox1.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            textBox1.ForeColor = cd.Color;
        }
    }
}
