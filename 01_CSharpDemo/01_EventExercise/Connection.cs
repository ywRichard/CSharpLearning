using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _01_EventExercise
{
    public delegate void MessageHandler(object source, MessageArriveEventArgs args);
    class Connection
    {
        public event MessageHandler GetMessage;
        private Timer time;
        public string Name { get; set; }

        public void Connect()
        {
            time.Start();
        }

        public void Disconnect()
        {
            time.Stop();
        }

        public Connection()
        {
            time = new Timer(500);

            time.Elapsed += CheckMessage;
        }

        private static Random r = new Random();
        private void CheckMessage(object sender, EventArgs e)
        {
            Console.WriteLine("CheckMessage");
            if (r.Next(0, 10) != 5)
                GetMessage?.Invoke(this, new MessageArriveEventArgs("使命必达", this.Name));
        }
    }
}
