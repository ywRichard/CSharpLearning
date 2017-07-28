using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30_自定义控件
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        //在自定义控件内得到Name and Password，传出给Winform; 在得到判断结果，显示
        public event EventHandler _evt;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this._evt != null)
            {
                MyEventArgs myEvent = new MyEventArgs();//注册事件
                myEvent.Name = txtName.Text;
                myEvent.Psw = txtPsw.Text;

                this._evt(this, myEvent);

                if (myEvent.Flag == true)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Psw { get; set; }
        public bool Flag { get; set; }

        public MyEventArgs()
        {
            this.Flag = false;
        }
    }
}
