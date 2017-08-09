using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinFormBasic
{
    public partial class Form1 : Form
    {
        RegisterPerson frm2;
        public Form1()
        {
            InitializeComponent();
            btnOk.Enabled = false;
            frm2 = new RegisterPerson();
        }

        private void textEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidateOk();
        }

        private void textJob_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "Programmer" || tb.Text.Length == 0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                tb.BackColor = Color.Red;
            }
            ValidateOk();
        }

        private void ValidateOk()
        {
            btnOk.Enabled = textJob.BackColor != Color.Red && txtName.BackColor != Color.Red;
        }

        private void btnNewPanel_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm3 = new _03_ListBoxAndCheckedListBox();
            frm3.Show();
        }
    }
}
