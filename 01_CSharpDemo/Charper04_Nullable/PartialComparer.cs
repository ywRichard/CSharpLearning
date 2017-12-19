using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper04_Nullable
{
    public class PartialComparer
    {
        public static int? Compare<T>(T first, T second)
        {
            return Compare(Comparer<T>.Default, first, second);
        }

        public static int? Compare<T>(Comparer<T> comparer, T first, T second)
        {
            var ret = comparer.Compare(first, second);
            return ret == 0 ? new int?() : ret;
        }

        public static int? ReferenceCompare<T>(T first, T second) where T : class
        {
            return first == second ? 0
                : first == null ? -1
                : second == null ? 1
                : new int?();
        }
    }
}
