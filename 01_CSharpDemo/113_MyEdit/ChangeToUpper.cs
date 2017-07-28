using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyEditPlus;
using System.Windows.Forms;

namespace MyNoteBook
{
    class ChangeToUpper:IEditPlus
    {

        public string ChangeString(TextBox tb)
        {
            return tb.Text.ToUpper();
        }

        public string Name
        {
            get { return "ToUpper"; }
        }
    }
}
