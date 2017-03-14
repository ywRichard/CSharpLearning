using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _超市收银项目
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {
        public abstract double GetMoney(double realMoney);
    }
}
