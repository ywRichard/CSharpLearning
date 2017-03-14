using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目练习第二遍
{
    //满M，减N
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

        public override double PayMoney(double realMoney)
        {
            return realMoney - (int)(realMoney / this.M) * (this.N);
        }
    }
}
