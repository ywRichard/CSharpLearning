using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    //折扣
    class CalRate:CalFather
    {
        public double Rate
        {
            get;
            set;
        }

        public CalRate(double rate)
        {
            this.Rate = rate;
        }

        public override double PayMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
