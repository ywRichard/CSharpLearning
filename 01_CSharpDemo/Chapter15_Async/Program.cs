using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter15_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryAsyncForm();
            //TryWrappedException();
            //TryArgumentValidation();

            TryAwaitingCancellation();
        }

        private static void TryAsyncForm()
        {
            Application.Run(new AsyncForm());
        }

        private static void TryWrappedException()
        {
            WrappedException.MainAsync().Wait();
        }

        private static void TryArgumentValidation()
        {
            ArgumentValidationAsync.MainAsync().Wait();
        }

        private static void TryAwaitingCancellation()
        {
            AwaitingCancellation.MainAsync();
        }
    }
}
