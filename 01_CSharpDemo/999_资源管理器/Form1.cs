using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _16_资源管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\SESA435900\Documents\04.基础加强";

            tv.BeginUpdate();
            tv.Nodes.Clear();
            List<string> list = new List<string>();
            GetNameByPath(path, tv.Nodes);

            //for (int i = 0; i < pathArray.Length; i++)
            //{
            //    tv.Nodes.Add(Path.GetFileName(pathArray[i]));
            //}

            //for (int i = 0; i < fileArray.Length; i++)
            //{
            //    tv.Nodes.Add(Path.GetFileName(fileArray[i]));
            //}

            tv.EndUpdate();
        }

        private void GetNameByPath(string path, TreeNodeCollection tnc)
        {
            string[] name = Directory.GetDirectories(path);

            for (int i = 0; i < name.Length; i++)
            {
                string nameFolder = Path.GetFileName(name[i]);
                TreeNode tn = tnc.Add(nameFolder);

                string[] nameFile = Directory.GetFiles(name[i]);

                GetNameByPath(name[i], tn.Nodes);

                for (int j = 0; j < nameFile.Length; j++)
                {
                    tn.Nodes.Add(Path.GetFileName(nameFile[j]));
                }

                
            }
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = @"C:\Users\SESA435900\Documents\04.基础加强";
            string fileName = Path.Combine(path, tv.SelectedNode.FullPath);
            

            string extensionName = Path.GetExtension(fileName);

            if (".txt"==extensionName)
            {
                txtName.Text = File.ReadAllText(fileName, Encoding.Default);
            }
            else
            {
                txtName.Text = "";
            }
        }



    }
}
