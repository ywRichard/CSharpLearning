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
    public partial class frmContainer : Form
    {
        private int counter;
        public frmContainer()
        {
            InitializeComponent();

            counter = 1;
            var child = new frmEditor(this, counter);
            child.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newEditor = new frmEditor(this, ++counter);
            newEditor.Show();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
