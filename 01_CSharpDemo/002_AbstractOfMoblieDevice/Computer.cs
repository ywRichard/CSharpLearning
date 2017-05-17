using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_AbstractOfMoblieDevice
{
    public class Computer
    {
        public StorageDevice SD { get; set; }

        public void Write()
        {
            SD.Write();
        }
        public void Read()
        {
            SD.Read();
        }
    }
}
