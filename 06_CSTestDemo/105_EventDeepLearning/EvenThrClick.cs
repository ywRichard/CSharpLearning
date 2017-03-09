using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30_事件的三连击
{
    public partial class EvenThrClick : UserControl
    {
        public delegate void MyEvent();
        public EvenThrClick()
        {
            InitializeComponent();
        }
        int n = 0;
        public event MyEvent _met;//事件是由委托实现的。

        private void EventClick_Click(object sender, EventArgs e)
        {
            n++;

            if (n == 3)
            {
                n = 0;

                if (this._met != null)
                {
                    this._met();
                }
            }
        }
    }
}
