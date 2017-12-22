using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    public class LinqWhere
    {
        /// <summary>
        /// 实现参数检查，将数据处理部分封装到另一个方法中。
        /// 由于yield return有延迟执行的特点，这样就可以在方法调用时候就去执行参数检查。
        /// 而不是等到真正迭代数据的时候。
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<T> Where<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            //检查参数
            if (source == null || predicate == null)
            {
                throw new ArgumentNullException();
            }

            return WhereImple(source, predicate);
        }
        /// <summary>
        /// 该方法实现数据延迟处理，只有在执行了MoveNext()之后，才能返回一条一个结果。
        /// 该方法适用于读取大文件，例如对于存储了千万条log的日志记录。
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<T> WhereImple<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;//一次只读取一条
                }
            }
        }
    }
}
