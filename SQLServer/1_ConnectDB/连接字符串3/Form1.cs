using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 连接字符串3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            //ppg.SelectedObject = scsb;
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            ppg.SelectedObject = scsb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnectionStringBuilder scsb = ppg.SelectedObject as SqlConnectionStringBuilder;
            //MessageBox.Show(scsb.ToString());

            SqlConnectionStringBuilder scsb = ppg.SelectedObject as SqlConnectionStringBuilder;
            MessageBox.Show(scsb.ToString());
        }
    }
}
