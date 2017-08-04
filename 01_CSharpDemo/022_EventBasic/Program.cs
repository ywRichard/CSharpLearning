using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _022_EventBasic
{
    class Program
    {
        #region Event Basic
        //static int counter = 0;
        //static string displayString = "I will be on display! ";
        //static void WriteChar(object source, ElapsedEventArgs e)
        //{
        //    Console.Write(displayString[counter++ % displayString.Length]);
        //}
        #endregion

        static void Main(string[] args)
        {
            #region MyRegion
            //Timer myTimer = new Timer(100);
            //myTimer.Elapsed += WriteChar;
            //myTimer.Start();
            #endregion

            #region Arrived Message
            Connection myConnection1 = new Connection { Name = "First connection" };
            Connection myConnection2 = new Connection { Name = "Second connection" };
            Display myDisplay = new Display();

            myConnection1.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection2.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);

            myConnection1.Connect();
            myConnection2.Connect();
            #endregion
            Console.ReadKey();
        }


    }
}
