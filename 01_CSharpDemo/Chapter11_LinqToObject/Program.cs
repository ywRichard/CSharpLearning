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
            TryJoinWhere();
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

        #region JoinDemo

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

    }
}
