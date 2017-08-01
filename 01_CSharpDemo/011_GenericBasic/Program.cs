using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_GenericBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 可空类型
            //System.Nullable<int> nullInt;
            //int? nullInt;
            //nullInt = null;

            //if (nullInt == null)
            //{
            //    Console.WriteLine("nullInt={0}", nullInt.GetValueOrDefault(3));
            //}

            ////引用类型会抛异常 -> 对象为null调用成员
            //if (nullInt.HasValue)
            //{
            //    Console.WriteLine("nullInt.HasValue");
            //}

            //int? para = null;
            //int para2 = 5;
            //int? result = para * para2;
            //Console.WriteLine(result);
            #endregion

            #region ??运算符
            int? obj1 = null;
            int? obj2 = null;
            //若第一个null,则判断第二个。
            //int result = obj1 * 2 ?? 5;
            int? result = obj1 * obj2;
            Console.WriteLine(result);
            #endregion
        }
    }
}
