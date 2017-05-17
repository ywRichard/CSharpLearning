using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29_委托的三连击
{
    public delegate void MyDel();
    public partial class UserThreeClick : UserControl
    {
        public UserThreeClick()
        {
            InitializeComponent();
        }
        int n = 0;
        public MyDel _mdl;

        private void ThreeClick_Click(object sender, EventArgs e)
        {
            n++;
            if (n==3)
            {
                n = 0;
                if (this._mdl != null)
                {
                    this._mdl();
                }
            }
        }

        private void UserThreeClick_Load(object sender, EventArgs e)
        {

        }
    }
}
