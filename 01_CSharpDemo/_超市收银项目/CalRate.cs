using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
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

        public override double GetMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
