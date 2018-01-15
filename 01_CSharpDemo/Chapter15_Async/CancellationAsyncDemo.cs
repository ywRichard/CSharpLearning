using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Async
{
    class CancellationAsyncDemo
    {
        public static void MainAsync()
        {
            var task = ThrowCancellationException();
            Console.WriteLine(task.Status);
        }

        static async Task ThrowCancellationException()
        {
            throw new OperationCanceledException();
        }
    }
}
