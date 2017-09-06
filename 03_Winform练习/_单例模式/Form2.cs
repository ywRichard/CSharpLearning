using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _单例模式
{
    public partial class Form2 : Form
    {
        public static Form2 FormSingle = null;

        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingle()
        {
            if (FormSingle == null)
            {
                FormSingle = new Form2();
            }
            return FormSingle;
        }

        private static Form2 _instance;

        public static Form2 Instance
        {
            get
            {
                if (_instance==null||_instance.IsDisposed)
                {
                    _instance = new Form2();
                }
                return _instance;
            }
        }
    }
}
