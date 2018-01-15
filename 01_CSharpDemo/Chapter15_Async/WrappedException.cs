using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Async
{
    class WrappedException
    {
        public static async Task MainAsync()
        {
            Task<string> task = ReadFileAsync("garbage file");
            try
            {
                var text = await task;
                Console.WriteLine($"File contents:{text}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Caught Exception: {e.Message}");
            }
        }

        private static async Task<string> ReadFileAsync(string fileName)
        {
            using (var reader = File.OpenText(fileName))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
