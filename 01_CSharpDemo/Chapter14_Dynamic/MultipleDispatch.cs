using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Dynamic
{
    /// <summary>
    /// 对于静态类型，C#使用的是单一分发。
    /// 单一分发（single dispatch）：即通过对方法名称和参数信息进行重载解决得到目标方法，方法是唯一确定的。
    /// 
    /// 对于动态类型，使用的是多重分发。
    /// 多重分发（multiple dispatch）：在执行时根据实参的类型找到合适的方法。要实现对从分发，实参类型必须为dynamic类型的。
    /// </summary>
    public class MultipleDispatch
    {
        static int CountImpl<T>(ICollection<T> collection)
        {
            return collection.Count;
        }
        static int CountImpl(ICollection collection)
        {
            return collection.Count;
        }
        static int CountImpl(string text)
        {
            return text.Length;
        }
        static int CountImpl(IEnumerable collection)
        {
            var count = 0;
            foreach (object item in collection)
            {
                count++;
            }
            return count;
        }

        public static void PrintCount(IEnumerable collection)
        {
            dynamic d = collection;
            var count = CountImpl(d);

            Console.WriteLine(count);
        }
    }
}
