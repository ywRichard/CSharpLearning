using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_EventBasic
{
    public class MessageArrivedEventArgs : EventArgs
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }

        public MessageArrivedEventArgs()
        {
            _message = "No message sent.";
        }

        public MessageArrivedEventArgs(string newMessage)
        {
            _message = newMessage;
        }
    }
}
