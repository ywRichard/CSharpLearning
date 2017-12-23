using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryPartialMethod();
            //TryNameSpaceDemo();
            TryFixedSizeBufferDemo();
        }

        static void TryPartialMethod()
        {
            var pm = new PartialMethod();
        }

        static void TryNameSpaceDemo()
        {
            var name = new NameSpaceDemo();
        }

        static void TryFixedSizeBufferDemo()
        {
            FixedSizeBufferDemo.MainDemo();
        }
    }
}
