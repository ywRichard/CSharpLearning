using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter12_LinqToOther.LINQtoRx
{
    /// <summary>
    /// Returns a random element from the given source.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If the source sequence implements <see cref="IList{T}"/>, this method
    /// will pick a random index based on the count of the list, and then
    /// return that element directly.
    /// </para>
    /// <para>
    /// If the source sequence implements <see cref="ICollection{T}"/> but not
    /// <see cref="IList{T}"/>, the index will still be chosen randomly based
    /// on the count, but then the element at that index will be returned
    /// by iterating that many times.
    /// </para>
    /// <para>
    /// Otherwise, a random replacement strategy is used: we start with the
    /// first element as our "current" value, and replace it with the second
    /// element with a probability of 1/2. The third element replaces "current"
    /// with a probability of 1/3, and so on until we reach the end of the sequence.
    /// This will yield a uniform distribution, but requires as many calls to
    /// the random number generator as there are elements in the sequence - and
    /// the entire sequence will be iterated over before returning. The sequence
    /// will only be evaluated once, however, so this method can still be used
    /// with long sequences which cannot be replayed.
    /// </para>
    /// </remarks>
    /// <typeparam name="T">The type of the elements in source.</typeparam>
    /// <param name="source">A sequence of values to pick a random element from</param>
    /// <param name="random">A random number generator</param>
    /// <returns>An element picked at random from the source</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="source"/> or <paramref name="random"/> is null.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// <paramref name="source"/> is empty.
    /// </exception>
    public class ObservableDemo
    {
        public static void Basic()
        {
            var observable = Observable.Range(0, 10);
            observable.Subscribe(x => Console.WriteLine($"Received:{x}"),
                e => Console.WriteLine($"Error:{e}"),
                () => Console.WriteLine("Finished"));
        }

        public static void WhereDemo()
        {
            var numbers = Observable.Range(0, 10);
            var result = from num in numbers
                         where num % 2 == 0
                         select num;
            result.Subscribe(Console.WriteLine);
        }

        /// <summary>
        /// 取模并分组
        /// </summary>
        public static void GroupDemo()
        {
            var numbers = Observable.Range(0, 10);
            var result = from num in numbers
                         group num by num % 3;
            result.Subscribe(group => group.Subscribe
            (x => Console.WriteLine($"Value:{x}, Group:{group.Key}")));
        }

        public static void SelectManyDemo()
        {
            var result = from x in Observable.Range(1, 3)
                         from y in Observable.Range(1, x)
                         select new { x, y };
            result.Subscribe(Console.WriteLine);
        }

        public static void SelectManyWithThreadPool()
        {
            var result = from x in Observable.Range(1, 3)
                         from y in Observable.Range(1, x, Scheduler.Default)
                         select new { x, y };
            result.Subscribe(Console.WriteLine);

            Thread.Sleep(1000);
        }
    }

}
