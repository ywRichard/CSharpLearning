using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;

namespace Chapter11_LinqToObject.LogFile
{
    internal class LogEntry
    {
        private static readonly IDictionary<string, EntryType> EntryTypeLookup =
            ((EntryType[])Enum.GetValues(typeof(EntryType))).ToDictionary(entry => entry.ToString());

        public DateTime Timestamp { get; set; }
        public EntryType Type { get; set; }
        public string Message { get; set; }

        private char[] Tab = { '\t' };

        public LogEntry(string line)
        {
            var parts = line.Split(Tab, 3);
            Timestamp = DateTime.ParseExact(parts[0], "u", CultureInfo.InvariantCulture);
            Type = EntryTypeLookup[parts[1]];
            Message = parts[2];
        }

        public override string ToString()
        {
            return Timestamp.ToString("u", CultureInfo.InvariantCulture) + "\t" +
                   Type + "\t" +
                   Message;
        }

        internal void WriteTo(TextWriter writer)
        {
            writer.WriteLine(ToString());
        }
    }
}