using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12_LinqToOther.Test
{
    /// <summary>
    /// 
    /// </summary>
    public static class Extensions
    {
        public static T RandomElement<T>(this IEnumerable<T> source, Random random)
        {
            //验证参数，实际上应该再重载一个私有的方法去迭代集合
            //公有方法验证参数，私有方法实现迭代
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (random == null)
                throw new ArgumentNullException(nameof(random));

            //优化集合，选择最合适的类型
            ICollection collection = source as ICollection;
            if (collection != null)
            {
                var count = collection.Count;
                if (count == 0)
                    throw new InvalidOperationException("Sequence was empty");

                var index = random.Next(count);
                return source.ElementAt(index);//进一步优化集合的取值方式，通过索引获取特定元素一般很慢
            }

            ICollection<T> genericCollection = source as ICollection<T>;
            if (genericCollection != null)
            {
                var count = genericCollection.Count;
                if (count == 0)
                    throw new InvalidOperationException("Sequence was empty");

                var index = random.Next(count);
                return source.ElementAt(index);
            }

            //foreach和using都会自动释放迭代器
            //对第一个元素执行不同的操作，手动实现迭代器。并用using去释放迭代器
            //处理低效的情况
            using (IEnumerator<T> iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                    throw new InvalidOperationException("Sequence was empty");

                var countSoFar = 1;
                var current = iterator.Current;
                while (iterator.MoveNext())
                {
                    countSoFar++;
                    if (random.Next(countSoFar) == 0)
                    {
                        //有时需要取代当前推测
                        current = iterator.Current;
                    }
                }

                return current;
            }
        }
    }
}
