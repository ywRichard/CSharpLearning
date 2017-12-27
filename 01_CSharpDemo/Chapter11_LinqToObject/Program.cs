using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCastOfType();
            //TryExplicitType();
            //TryLet();
            //TryJoin();
            //TryJoinWhere();

            //TryJoinInto();
            //TryJoinInto1();

            //TryCrossJoin();

            //TryGroupBy();
            //TryGroupBy1();

            //TryInto();
            TryIntoMultiple();
        }

        /// <summary>
        /// Cast()和OfType()将集合转换成IEnumerable<T>
        /// </summary>
        static void TryCastOfType()
        {
            var list = new ArrayList { "List", "Second", "Third" };
            IEnumerable<string> strings = list.Cast<string>();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            list = new ArrayList { 1, "not an int", 2, 3 };
            IEnumerable<int> ints = list.OfType<int>();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 声明显示类型的范围变量，编译器在会调用Cast()来保证被查询序列具有合适的类型
        /// </summary>
        static void TryExplicitType()
        {
            var list = new ArrayList { "List", "Second", "Third" };
            IEnumerable<string> strings = from string entry in list
                                          select entry.Substring(0, 3);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        static void TryLet()
        {
            var query = from user in SampleData.AllUsers
                        let length = user.Name.Length
                        orderby length
                        select new { Name = user.Name, Length = length };
            foreach (var entry in query)
            {
                Console.WriteLine($"{entry.Length}: {entry.Name}");
            }
        }

        #region join demo

        static void TryJoin()
        {
            var result = from defect in SampleData.AllDefects
                         join susbscription in SampleData.AllSubscriptions
                             on defect.Project equals susbscription.Project
                         select new { defect.Summary, susbscription.EmailAddress };
            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.EmailAddress}: {entry.Summary}");
            }
        }
        static void TryJoinWhere()
        {
            //var result = from defect in SampleData.AllDefects
            //    where defect.Status == Status.Closed
            //    join subscription in SampleData.AllSubscriptions
            //        on defect.Project equals subscription.Project
            //    select new {defect.Summary, subscription.EmailAddress};

            var result = from subscription in SampleData.AllSubscriptions
                         join defect in (from defect in SampleData.AllDefects
                                         where defect.Status == Status.Closed
                                         select defect)
                             on subscription.Project equals defect.Project
                         select new { defect.Summary, subscription.EmailAddress };

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.EmailAddress}: {entry.Summary}");
            }
        }
        static void TryGetCount()
        {
            foreach (var project in SampleData.AllProjects)
            {
                Console.WriteLine($"{project.Name} Count: {SampleData.AllDefects.Count(p => p.Project.Name == project.Name)}");
            }
        }

        #endregion

        #region join into Demo

        static void TryJoinInto()
        {
            var result = from defect in SampleData.AllDefects
                         join subscription in SampleData.AllSubscriptions
                             on defect.Project equals subscription.Project
                             into groupSubscriptions
                         select new { Defect = defect, Subscription = groupSubscriptions };

            foreach (var entry in result)
            {
                Console.WriteLine(entry.Defect.Summary);
                foreach (var subscription in entry.Subscription)
                {
                    Console.WriteLine($"{subscription.EmailAddress}");
                }
            }
        }
        static void TryJoinInto1()
        {
            var dates = new DateTimeRange(SampleData.Start, SampleData.End);

            //var result = from date in dates
            //             join defect in SampleData.AllDefects
            //                 on date equals defect.Created.Date
            //                 into joined
            //             select new { Date = date, Count = joined.Count() };

            var result = dates.GroupJoin(SampleData.AllDefects,
                date => date,
                defect => defect.Created.Date,
                (date, joined) => new { Date = date, Count = joined.Count() });

            foreach (var grouped in result)
            {
                Console.WriteLine($"{grouped.Date.ToShortDateString()},{grouped.Count}");
            }
        }

        #endregion

        #region cross join

        static void TryCrossJoin()
        {
            //var result = from left in Enumerable.Range(1, 4)
            //             from right in Enumerable.Range(11, left)
            //             select new { Left = left, Right = right };

            var result = Enumerable.Range(1, 4)
                .SelectMany(left => Enumerable.Range(11, left),
                           (left, right) => new { Left = left, Right = right });

            foreach (var item in result)
            {
                Console.WriteLine($"Left={item.Left}, Right={item.Right}");
            }
        }

        #endregion

        /// <summary>
        /// 将分组结果按键和值形式保存
        /// group (value) by (key)
        /// </summary>
        static void TryGroupBy()
        {
            //var result = from defect in SampleData.AllDefects
            //             where defect.AssignedTo != null
            //             group defect by defect.AssignedTo;

            var result = SampleData.AllDefects
                .Where(defect => defect.AssignedTo != null)
                .GroupBy(defect => defect.AssignedTo);

            foreach (var entry in result)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var defect in entry)
                {
                    Console.WriteLine($"({defect.Severity}) {defect.Summary}");
                }

                Console.WriteLine();
            }
        }
        static void TryGroupBy1()
        {
            //var result = from defect in SampleData.AllDefects
            //             where defect.AssignedTo != null
            //             group defect.Summary by defect.AssignedTo;

            var result = SampleData.AllDefects
                .Where(defect => defect.AssignedTo != null)
                .GroupBy(defect => defect.AssignedTo, defect => defect.Summary);

            foreach (var entry in result)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var summary in entry)
                {
                    Console.WriteLine($"  {summary}");
                }
            }
        }

        /// <summary>
        /// 查询延续
        /// 把一个查询表达式的结果作为另一个查询表达式的原始序列
        /// </summary>
        static void TryInto()
        {
            //var result = from defect in SampleData.AllDefects
            //             where defect.AssignedTo != null
            //             group defect by defect.AssignedTo
            //    into grouped
            //             select new
            //             {
            //                 Assignee = grouped.Key,
            //                 Count = grouped.Count()
            //             };

            var result = SampleData.AllDefects
                .Where(defect => defect.AssignedTo != null)
                .GroupBy(defect => defect.AssignedTo)
                .Select(grouped => new { Assignee = grouped.Key, Count = grouped.Count() });

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Assignee.Name}: {entry.Count}");
            }
        }
        static void TryIntoMultiple()
        {
            //var result = from defect in SampleData.AllDefects
            //             where defect.AssignedTo != null
            //             group defect by defect.AssignedTo
            //    into grouped
            //             select new
            //             {
            //                 Assignee = grouped.Key,
            //                 Count = grouped.Count()
            //             }
            //    into list
            //             orderby list.Count descending
            //             select list;

            var result = SampleData.AllDefects
                .Where(defect => defect.AssignedTo != null)
                .GroupBy(defect => defect.AssignedTo)
                .Select(grouped => new { Assignee = grouped.Key, Count = grouped.Count() })
                .OrderByDescending(list => list.Count);

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Assignee.Name}: {entry.Count}");
            }
        }
    }
}
