using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    /// <summary>
    /// 买M，送N
    /// </summary>
    class CalMN : CalFather
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

        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }

        public override double GetMoney(double realMoney)
        {
            if (realMoney < this.M)
            {
                return realMoney - (int)(realMoney / this.M) * this.N;
            }
            else
            {
                return realMoney;
            }
        }
    }
}
