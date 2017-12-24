using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_ExtensionMethod
{
    public static class NullUtil
    {
        public static bool IsNull(this object x)
        {
            return x == null;
        }
    }
}
