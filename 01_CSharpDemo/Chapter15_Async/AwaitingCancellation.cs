using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter15_Async
{
    class AwaitingCancellation
    {
        public static void MainAsync()
        {
            var source = new CancellationTokenSource();
            var task = DelayFor30Seconds(source.Token);
            source.CancelAfter(TimeSpan.FromSeconds(1));
            Console.WriteLine($"Initial status:{task.Status}");
            try
            {
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Caught {e.InnerExceptions[0]}");
            }
            Console.WriteLine($"Final status: {task.Status}");
        }

        static async Task DelayFor30Seconds(CancellationToken token)
        {
            Console.WriteLine("Waiting for 30 seconds...");
            await Task.Delay(TimeSpan.FromSeconds(30), token);
        }
    }
}
