using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _02_ListView
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection _folderCol;
        public Form1()
        {
            InitializeComponent();
            _folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"C:\");
            _folderCol.Add(@"C:\");
        }

        private void CreateHeadersAndFillListView()
        {
            var colHead = new ColumnHeader();
            colHead.Text = "FileName";
            lvFilesFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            lvFilesFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Last Accessed";
            lvFilesFolders.Columns.Add(colHead);
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvItem;
                ListViewItem.ListViewSubItem lvSubItem;

                if (string.IsNullOrEmpty(root))
                    return;

                var dir = new DirectoryInfo(root);
                var dirs = dir.GetDirectories();
                var files = dir.GetFiles();
                lvFilesFolders.Items.Clear();
                lblPath.Text = root;
                lvFilesFolders.BeginUpdate();

                foreach (var di in dirs)
                {
                    lvItem = new ListViewItem();
                    lvItem.Text = di.Name;
                    lvItem.ImageIndex = 0;
                    lvItem.Tag = di.FullName;

                    lvSubItem = new ListViewItem.ListViewSubItem();
                    lvSubItem.Text = "";
                    lvItem.SubItems.Add(lvSubItem);

                    lvSubItem = new ListViewItem.ListViewSubItem();
                    lvSubItem.Text = di.LastAccessTime.ToString();
                    lvItem.SubItems.Add(lvSubItem);
                    lvFilesFolders.Items.Add(lvItem);
                }

                foreach (var fi in files)
                {
                    lvItem = new ListViewItem();
                    lvItem.Text = fi.Name;
                    lvItem.ImageIndex = 1;
                    lvItem.Tag = fi.FullName;

                    lvSubItem = new ListViewItem.ListViewSubItem();
                    lvSubItem.Text = fi.Length.ToString();
                    lvItem.SubItems.Add(lvSubItem);

                    lvSubItem = new ListViewItem.ListViewSubItem();
                    lvSubItem.Text = fi.LastAccessTime.ToString();
                    lvItem.SubItems.Add(lvSubItem);
                    lvFilesFolders.Items.Add(lvItem);
                }

                lvFilesFolders.EndUpdate();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                throw;
            }
        }

        private void lvFilesFolders_ItemActivate(object sender, EventArgs e)
        {
            var lw = (System.Windows.Forms.ListView)sender;
            var fileName = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex!=0)
            {
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch{ return; }
            }
            else
            {
                PaintListView(fileName);
                _folderCol.Add(fileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_folderCol.Count > 1)
            {
                PaintListView(_folderCol[_folderCol.Count - 2].ToString());
                _folderCol.RemoveAt(_folderCol.Count - 1);
            }
            else
                PaintListView(_folderCol[0].ToString());
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvFilesFolders.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvFilesFolders.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvFilesFolders.View = View.List;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvFilesFolders.View = View.Details;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvFilesFolders.View = View.Tile;
        }
    }
}
