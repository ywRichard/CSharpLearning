using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _保存文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //指定初始化路径
            sfd.InitialDirectory = @"C:\Users\Richard\Desktop\qwe";            
            //更新标题栏
            sfd.Title = "哈哈，好的呢";
            //选择所要保存的文件类型
            sfd.Filter = "文本文件|*.txt|多媒体文件|*.wav|所有文件|*.*";
            //显示对话框
            sfd.ShowDialog();
            //得到所选文件的路径,文件名            
            string fileName = Path.GetFileName(sfd.FileName);
            string directoryName = Path.GetDirectoryName(sfd.FileName);
            //写入内容到文本文件中，保存到指定路径中
            using (FileStream fs = new FileStream(sfd.FileName,FileMode.Create,FileAccess.Write))
            {
                byte[] buffer = new byte[5 * 1024 * 1024];
                buffer = Encoding.Default.GetBytes(textBox1.Text);
                fs.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
