using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_MDIBasic
{
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();
            frmChild child = new frmChild(this);
            child.Show();
        }
    }
}
