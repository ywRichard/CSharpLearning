using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //验证码是图片
            Bitmap image = new Bitmap(150, 30);
            //添加字符内容到图片文件中
            Graphics g = Graphics.FromImage(image);
            //字符内容
            Random random = new Random();

            string str = "";
            for (int i = 0; i < 6; i++)
            {
                str += random.Next(0, 10).ToString();
            }
            //图片内容的字体和颜色随机
            string[] font = {"微软雅黑","宋体","楷体","仿宋","隶书"};
            Color[] color = {Color.Yellow,Color.Red,Color.Black,Color.Green,Color.Gray,Color.Blue};
            
            for (int i = 0; i < str.Length; i++)
            {
                Point p = new Point(i*20,0);
                g.DrawString(str[i].ToString(), new Font(font[random.Next(0, font.Length)], 20, FontStyle.Bold), new SolidBrush(color[random.Next(0, color.Length)]), p);
            }            
            //随机点和直线增加模糊度
            for (int i = 0; i < 20; i++)//增加线
            {
                Point p1 = new Point(random.Next(0, image.Width), random.Next(0, image.Height));
                Point p2 = new Point(random.Next(0, image.Width), random.Next(0, image.Height));
                g.DrawLine(new Pen(Brushes.Blue), p1, p2);
            }

            for (int i = 0; i < 500; i++)//增加点
            {
                image.SetPixel(random.Next(0,image.Width),random.Next(0,image.Height),Color.Yellow);
            }
            //图片要加载到pictureBox中显示
            pictureBox1.Image = image;
        }
    }
}
