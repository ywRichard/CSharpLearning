using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    /// <summary>
    /// 模拟迭代器迭代的顺序，验证延迟执行的特性
    /// </summary>
    class SimulateIteratorProcess
    {
        private static readonly string Padding = new string(' ', 30);

        public static IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine($"{Padding} Start of CreateEnumerable()");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{Padding} About to yield {i}");
                yield return i;
                Console.WriteLine($"{Padding} After yield");
            }
            Console.WriteLine($"{Padding} Yielding final value");
            yield return -1;

            Console.WriteLine($"{Padding} End of CreateEnumerable()");
        }
    }
}
