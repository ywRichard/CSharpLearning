using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryNullableDisplay();
            TryBoxNullable();
        }

        #region Nullable Convert Value
        /// <summary>
        /// 转换有值和无值的可空类型
        /// </summary>
        /// <param name="x"></param>
        private static void Display(Nullable<int> x)
        {
            Console.WriteLine("HasValue:{0}", x.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine("Value:{0}", x.Value);
            }
            Console.WriteLine("GetValueOrDefault(): {0}", x.GetValueOrDefault());
            //指定返回的默认值
            Console.WriteLine("GetValueOrDefault(10): {0}", x.GetValueOrDefault(10));
            Console.WriteLine("ToString():\"{0}\"", x.ToString());
            Console.WriteLine("GetHashCode():\"{0}\"", x.GetHashCode());
            Console.WriteLine("==================");
        }

        private static void TryNullableDisplay()
        {
            //int? x = 5;
            Nullable<int> x = 5;
            //x=new int? (5);
            x = new Nullable<int>(5);
            Console.WriteLine("Instance with value:");
            Display(x);

            x = new Nullable<int>();//new空的值类型
            Console.WriteLine("Instance without value:");
            Display(x);
        }

        #endregion

        #region nullable box & unbox

        private static void TryBoxNullable()
        {
            Nullable<int> nullable = 5;
            object boxed = nullable;
            Console.WriteLine(boxed.GetType());//获得装箱后的类型

            int normal = (int)boxed;
            Console.WriteLine(normal);//拆箱 -> 值类型

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable);//拆箱 -> 可空的值类型

            nullable = new Nullable<int>();
            boxed = nullable;//装箱空的值类型

            Console.WriteLine(boxed == null);

            nullable = (Nullable<int>)boxed;//拆箱空的值类型
            Console.WriteLine(nullable.HasValue);
            Console.WriteLine("+++"+nullable+"====");
        }

        #endregion
    }
}
