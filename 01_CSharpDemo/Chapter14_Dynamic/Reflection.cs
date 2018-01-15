using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Dynamic
{
    /// <summary>
    /// Dynamic Type Inference
    /// </summary>
    public class Reflection
    {
        private static bool AddConditionallyImpl<T>(IList<T> list, T item)
        {
            if (list.Count < 10)
            {
                list.Add(item);
                foreach (var str in list)
                {
                    Console.WriteLine(str);
                }
                
                return true;
            }
            return false;
        }

        public static bool AddConditionally(dynamic list, dynamic item)
        {
            return AddConditionallyImpl(list, item);
        }
    }
}
