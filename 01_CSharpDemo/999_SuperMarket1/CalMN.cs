using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习一遍
{
    /// <summary>
    /// 买M减N
    /// </summary>
    class CalMN:CalFather
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;
        }
        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetPayMoney(double realMoney)
        {
            if (realMoney>M)
            {
                realMoney = realMoney - (int)(realMoney / M) * N;
            }
            return realMoney;
        }
    }
}
