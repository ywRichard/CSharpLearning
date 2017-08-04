using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_EventBasic
{
    public class Display
    {
        public void DisplayMessage(object source, EventArgs e)
        {
            Console.WriteLine("Message arrived from: {0}", ((Connection)source).Name);
            Console.WriteLine("Message Text: {0}", ((MessageArrivedEventArgs)e).Message);
        }
    }
}
