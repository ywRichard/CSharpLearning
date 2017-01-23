using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            int day = 0;
            string[] month = cboMonth.SelectedItem.ToString().Split(new char[] { '月' });
            switch (month[0])
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12": day = 31;                    
                    break;
                case "2":
                    int year = Convert.ToInt32(cboYear.SelectedItem.ToString().Split(new char[] { '年' })[0]);
                    if (year % 400 == 0 || year % 4 == 0 && year % 100 == 0)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;
                    break;
            }
            for (int i = 1; i <=day; i++)
            {
                cboDay.Items.Add(i+"日");
            }
        }
    }
}
