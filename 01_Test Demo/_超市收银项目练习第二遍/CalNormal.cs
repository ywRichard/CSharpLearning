using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    //不打折
    class CalNormal:CalFather
    {
        public override double PayMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
