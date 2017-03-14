using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _21_Xml版大项目查询
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadXDocument("UserData.xml");
        }

        private void LoadXDocument(string path)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Root;
            List<UserData> list = new List<UserData>();

            foreach (XElement user in root.Elements())
            {
                list.Add(new UserData() { Id = user.Attribute("id").Value, Name = user.Element("name").Value, Password = user.Element("password").Value });
            }
            dgv.AutoGenerateColumns = false;//禁止自动生成列
            dgv.DataSource = list;//绑定数据
            if (dgv.RowCount>0)
            {
                dgv.SelectedRows[0].Selected = false;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }

    }
}
