using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEditPlus
{
    public interface IEditPlus
    {
        string Name { get; }
        string ChangeString(TextBox tb);
    }
}
