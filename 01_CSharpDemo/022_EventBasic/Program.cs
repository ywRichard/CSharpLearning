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
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived += myDisplay.DisplayMessage;
            myConnection.Connect();
            Console.ReadKey();
            #endregion
        }

        
    }
}
