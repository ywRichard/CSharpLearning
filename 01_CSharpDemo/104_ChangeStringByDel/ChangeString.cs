using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24_委托改变字符串
{
    public delegate string MyDel(string str);
    class ChangeString
    {
        public void ChangeStr(string[] aStr, MyDel mdl)
        {
            for (int i = 0; i < aStr.Length; i++)
            {
                aStr[i] = mdl(aStr[i]);
            }
        }
    }
}
