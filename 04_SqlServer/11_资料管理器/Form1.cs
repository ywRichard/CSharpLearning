using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _11_资料管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取大的分类            
            List<Category> list = LoadCategoryByParentId(-1);
            //把分类的名字加载到节点树上
            LoadCategoryByList(list, tv.Nodes);
        }

        private void LoadCategoryByList(List<Category> list, TreeNodeCollection tnc)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //tnc.Add(list[i].TName);
                TreeNode tn = tnc.Add(list[i].TName);
                tn.Tag = list[i].TId;
                LoadCategoryByList(LoadCategoryByParentId(list[i].TId), tn.Nodes);
            }
        }

        private List<Category> LoadCategoryByParentId(int p)
        {
            List<Category> list = new List<Category>();
            string sql = "select TId,TName from Category where TParentId="+p;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)//是否有行
                {
                    while (reader.Read())
                    {
                        Category ct = new Category();
                        ct.TId = Convert.ToInt32(reader["TId"]);
                        ct.TName = reader["TName"].ToString();
                        list.Add(ct);
                    }
                }
            }
            return list;
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(tv.SelectedNode.Tag.ToString());
            List<ContentInfo> list = new List<ContentInfo>();

            string sql = "select * from ContentInfo where dTId="+Convert.ToInt32(tv.SelectedNode.Tag);
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ContentInfo ct = new ContentInfo();
                        ct.DId = Convert.ToInt32(reader["DId"]);
                        ct.DTId = Convert.ToInt32(reader["DTId"]);
                        ct.DName = reader["DName"].ToString();
                        ct.DContent = reader["DContent"].ToString();
                        list.Add(ct);
                    }
                }
            }
            listBox.DataSource = list;
            listBox.DisplayMember = "DName";
            listBox.ValueMember = "DId";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBox.SelectedValue);
            string sql = "select dcontent from ContentInfo where DId="+id;
            object obj = SqlHelper.ExecuteScalar(sql);
            txtBox.Text = obj.ToString();
        }

    }
}
