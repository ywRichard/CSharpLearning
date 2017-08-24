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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPwd.Text)))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                msgDiv1.MsgDivShow("账号或者密码不能为空", 1);
                this.DialogResult = DialogResult.No;
            }

        }
    }
}
