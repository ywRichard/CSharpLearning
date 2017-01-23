using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //支持多选
            ofd.Multiselect = true;//支持多选
            //对话框的标题
            ofd.Title = "哈哈哈，好的";
            //选择显示的文件类型
            ofd.Filter = "文本文件|*.txt|多媒体文件(*.wav)|*.wav|图片文件|*.jpg|全部文件|*.*";
            //选择初始目录
            ofd.InitialDirectory = @"C:\Users\Richard\Desktop\picture";
            //显示对话框
            ofd.ShowDialog();

            //选择文件
            string path = ofd.FileName;

            if (path == "")
            {
                MessageBox.Show("路径为空");
                return;
            }
            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                fs.Read(buffer,0,buffer.Length);

                textBox1.Text = Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
