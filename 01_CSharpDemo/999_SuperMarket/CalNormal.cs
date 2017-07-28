using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    class CalNormal:CalFather
    {
        public override double GetMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
