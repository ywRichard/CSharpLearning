using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinFormBasic
{
    public partial class _03_ListBoxAndCheckedListBox : Form
    {
        public _03_ListBoxAndCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNewItem.Text.Length != 0)
            {
                lbCheckedSource.Items.Add(tbNewItem.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("清空列表框内容") == DialogResult.OK)
            {
                lbCheckedSource.Items.Clear();
                lbShow.Items.Clear();
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            foreach (var item in lbCheckedSource.SelectedItems)
            {
                var text = item.ToString();
                lbShow.Items.Add(text);
                //lbCheckedSource.Items.Remove(text);
            }
            lbCheckedSource.SelectedItems.Clear();
        }
    }
}
