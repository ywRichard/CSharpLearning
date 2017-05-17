using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace _ToolInterface
{
    public interface IEdit
    {
        string ChangeString(TextBox tb);

        string Name { get; }
    }
}
