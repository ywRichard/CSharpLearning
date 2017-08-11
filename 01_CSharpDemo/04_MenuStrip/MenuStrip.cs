using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MenuStrip
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void showHelpMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            helpToolStripMenuItem.Visible = item.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"Help.rtf");
            }
            catch { }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                richTextBox1.SaveFile(@"Help.rtf");
            }
            catch { }
        }
    }
}
