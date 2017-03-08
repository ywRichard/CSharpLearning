using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_外设读取
{
    public class UDisk:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取中。。。");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写入中。。。");
        }
    }
}
