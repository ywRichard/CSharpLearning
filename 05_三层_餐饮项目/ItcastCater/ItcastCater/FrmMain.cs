using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItcastCater
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            var frmMenbenInfo = new FrmMemberInfo();
            frmMenbenInfo.ShowDialog();
        }
    }
}
