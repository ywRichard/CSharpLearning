using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper03_Generic
{
    public class ReflectOfGeneric
    {
        public static void GetTypeof<X>()
        {
            Console.WriteLine(typeof(X));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<X>));
            Console.WriteLine(typeof(Dictionary<string,X>));
            Console.WriteLine(typeof(List<long>));
            Console.WriteLine(typeof(Dictionary<long,Guid>));
            Console.WriteLine(typeof(Dictionary<List<int>,string[]>));
        }
    }
}
