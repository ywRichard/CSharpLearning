using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _GDI_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            Point p1 = new Point(20, 30);
            Point p2 = new Point(100,200);

            g.DrawLine(pen, p1, p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Point p1 = new Point(50,80);
            Point p2 = new Point(250, 280);
            Size sz = new Size(p2);
            Rectangle rect = new Rectangle(p1,sz);
            g.DrawRectangle(pen, rect);
            g.DrawRectangle(pen,20,20,100,100);
        }
    }
}
