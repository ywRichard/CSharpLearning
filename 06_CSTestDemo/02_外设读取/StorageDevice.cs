using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_外设读取
{
    public abstract class StorageDevice
    {
        public abstract void Read();
        public abstract void Write();
    }
}
