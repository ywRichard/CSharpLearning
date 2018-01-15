using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Dynamic
{
    /// <summary>
    /// C#不支持泛型操作符
    /// 
    /// </summary>
    public static class DynamicSumExtension
    {
        public static T DynamicSum<T>(this IEnumerable<T> source)
        {
            dynamic total = default(T);
            foreach (T item in source)
            {
                //用动态类型使编译器动态的选择其他合适的操作符
                total = (T) (total + item);
            }
            return total;
        }
    }

    public static class TimeSpanExtensions
    {
        internal static TimeSpan Hours(this int hours)
        {
            return TimeSpan.FromHours(hours);
        }
        internal static TimeSpan Minutes(this int minutes)
        {
            return TimeSpan.FromMinutes(minutes);
        }
        internal static TimeSpan Seconds(this int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }
    }
}
