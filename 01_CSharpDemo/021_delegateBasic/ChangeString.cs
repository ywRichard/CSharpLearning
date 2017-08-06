using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _021_delegateBasic
{
    public delegate string ChangeStringDel(string str);
    class ChangeString
    {
        public void ChangeStr(string[] aStr, ChangeStringDel mdl)
        {
            for (int i = 0; i < aStr.Length; i++)
            {
                aStr[i] = mdl(aStr[i]);
            }
        }
    }
}
