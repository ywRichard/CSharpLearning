using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_EventBasic
{
    public class Display
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message arrived:{0}", message);
        }
    }
}
