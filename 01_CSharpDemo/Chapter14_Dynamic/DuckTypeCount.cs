using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Dynamic
{
    /// <summary>
    /// 鸭子类型：只有明确的方法名称和参数，但是没有确切的类型。
    /// 在BuildTime转译时，仅依赖方法名称和参数，而不是具体的类型。
    /// 鸭子类型是关注执行方法而忽略所属类型的一种规定，可能这个类型根本不存在。适用于某些不知道确切的调用类型，以及这些类型之间没有联系。这些类型之间只存放着方法名相同的方法成员。
    /// 这不同于抽象类或者接口种的成员，需要有继承关系才能使用。
    /// </summary>
    public class DuckTypeCount
    {
        public static void PrintCount(IEnumerable collection)
        {
            dynamic d = collection;
            int count = d.Count;
            Console.WriteLine(count);
        }
    }
}
