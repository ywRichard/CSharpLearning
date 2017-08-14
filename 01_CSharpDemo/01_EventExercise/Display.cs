using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EventExercise
{
    internal class Display
    {
        public void DisplayMessage(object source,EventArgs args)
        {
            Console.WriteLine("========From {0}========",((Connection)source).Name);
            Console.WriteLine(((MessageArriveEventArgs)args).Messsage);
            Console.WriteLine(((MessageArriveEventArgs)args).Source);
        }
    }
}
