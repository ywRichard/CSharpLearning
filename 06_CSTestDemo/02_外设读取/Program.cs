using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_外设读取
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer cp = new Computer();
            cp.SD = new MP3();
            cp.Write();
            cp.Read();
            Console.ReadLine();
        }
    }
}
