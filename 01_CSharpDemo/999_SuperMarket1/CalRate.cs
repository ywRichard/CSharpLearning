using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    /// <summary>
    /// 打折类
    /// </summary>
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

        public override double GetPayMoney(double realMoney)
        {
            realMoney = realMoney * this.Rate;
            return realMoney;
        }
    }
}
