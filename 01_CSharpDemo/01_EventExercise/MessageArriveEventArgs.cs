using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EventExercise
{
    public class MessageArriveEventArgs : EventArgs
    {
        public string Messsage { get; set; }

        public string Source { get; set; }
        public MessageArriveEventArgs()
        {
            Messsage = "";
            Source = "";
        }
        public MessageArriveEventArgs(string message,string source)
        {
            Messsage = message;
            Source = source;
        }
    }
}
