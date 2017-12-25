using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_LinqToObject.LogFile
{
    class LogReader
    {
        public static IEnumerable<string> ReadLines(string fileName)
        {
            using (var reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        static void GetLog()
        {
            var query = from file in Directory.GetFiles(@"c:\CSharpInDepthLogs", "*.log")
                        from line in ReadLines(file)
                        let entry = new LogEntry(line)
                        where entry.Type == EntryType.Error
                        select entry;

            Console.WriteLine($"Total errors: {query.Count()}");

        }
    }
}
