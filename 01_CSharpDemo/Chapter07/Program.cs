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
            TryPartialMethod();
        }

        static void TryPartialMethod()
        {
            var pm = new PartialMethod();
        }
    }
}
