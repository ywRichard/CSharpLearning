using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.Model
{
    public class ActionComparer : IEqualityComparer<ActionInfo>
    {
        public bool Equals(ActionInfo x, ActionInfo y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(ActionInfo obj)
        {
            return obj.GetHashCode();
        }
    }
}
