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
    public partial class RegisterPerson : Form
    {
        public RegisterPerson()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var outStr = "";
            if (tbName.Text.Length != 0)
                outStr += string.Format("Name: {0}", tbName.Text) + "\r\n";
            else
                outStr += "Missing Name \r\n";

            if (tbAge.Text.Length != 0)
                outStr += string.Format("Age: {0}", tbAge.Text) + "\r\n";
            else
                outStr += "Missing Age \r\n";

            if(cbGraduate.Checked)
                outStr += "The Person Graduate";
            else
                outStr += "The Person Ungraduate";

            foreach (var item in gbGender.Controls)
            {
                var control = (RadioButton)item;
                if (control.Checked)
                {
                    outStr += String.Format("Gender: {0}", control.Text);
                }
            }

            tbOut.Text = outStr;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Gender Gender { get; set; }
        public bool Graduate { get; set; }
    }
    enum Gender
    {
        Male,
        Female
    }
}
