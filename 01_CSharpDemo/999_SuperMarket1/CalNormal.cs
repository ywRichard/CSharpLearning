using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    class CalNormal:CalFather
    {
        //不打折
        public override double GetPayMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
