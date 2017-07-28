using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_AbstractOfMoblieDevice
{
    public abstract class StorageDevice
    {
        public abstract void Read();
        public abstract void Write();
    }
}
