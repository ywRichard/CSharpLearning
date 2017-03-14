using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _19_XML读取练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("11.xml");
            XElement root = xdoc.Root;
            LoadXElement(root, tv.Nodes);
        }

        private void LoadXElement(XElement root, TreeNodeCollection tnc)
        {
            foreach (XElement item in root.Elements())
            {
                if (item.Elements().Count()>0)//节点包含子节点
                {
                    TreeNode tn = tnc.Add(item.Name.ToString());
                    LoadXElement(item,tn.Nodes);//实现递归
                }
                else
                {
                    tnc.Add(item.Value);
                }
            }
        }

    }
}
