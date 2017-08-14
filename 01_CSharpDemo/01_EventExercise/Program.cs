using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EventExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var con1 = new Connection { Name = "Connect1" };
            var con2 = new Connection { Name = "Connect2" };
            var myDisplay = new Display();
            con1.GetMessage += new MessageHandler(myDisplay.DisplayMessage);
            con2.GetMessage += new MessageHandler(myDisplay.DisplayMessage);

            con1.Connect();
            con2.Connect();

            Console.ReadKey();
        }

    }
}
