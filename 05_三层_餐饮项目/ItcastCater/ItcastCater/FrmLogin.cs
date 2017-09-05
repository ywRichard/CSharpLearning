using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItcastCater.BLL;

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
            if (CheckText())
            {
                string msg = "";
                var user = new UserInfoBLL();
                if (user.IsLoginByName(txtName.Text, Common.GetStringMD5(txtPwd.Text), out msg))
                {
                    msgDiv1.MsgDivShow(msg, 1,Bind);
                }
                else
                {
                    msgDiv1.MsgDivShow(msg, 1);
                }
            }
        }

        private void Bind()
        {
            this.DialogResult = DialogResult.OK;
        }

        private bool CheckText()
        {
            if (!(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPwd.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
