using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_AbstractOfMoblieDevice
{
    public class MP3:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入中...");
        }

        public void Play()
        {
            Console.WriteLine("你是我的小呀小苹果");
        }
    }
}
