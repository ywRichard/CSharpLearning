using Chapter12_LinqToOther.QueryableDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12_LinqToOther
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryLINQtoSQL();
            //TryLINQtoSQL1();
            //TryLINQtoSQLwithJoin();

            //TryFakeQuery();
            TryFakeQuery1();
        }

        #region 输出SQL表达式树
        static void TryLINQtoSQL()
        {
            using (var context = new DefectModelDataContext())
            {
                context.Log = Console.Out;
                var tim = context.Users
                    .Where(user => user.Name == "Tim Trotter")
                    .Single();

                var result = from defect in context.Defects
                             where defect.Status != Status.Closed
                             where defect.AssignedTo == tim
                             select defect.Summary;

                foreach (var summary in result)
                {
                    Console.WriteLine(summary);
                }
            }
        }
        static void TryLINQtoSQL1()
        {
            using (var context = new DefectModelDataContext())
            {
                context.Log = Console.Out;
                var result = from user in context.Users
                             let length = user.Name.Length
                             orderby length
                             select new { Name = user.Name, Length = length };

                foreach (var entry in result)
                {
                    Console.WriteLine($"{entry.Length}: {entry.Name}");
                }
            }
        }
        static void TryLINQtoSQLwithJoin()
        {
            using (var context = new DefectModelDataContext())
            {
                context.Log = Console.Out;
                var result = from defect in context.Defects
                             join subscription in context.NotificationSubscriptions
                                 on defect.Project equals subscription.Project
                             select new { defect.Summary, subscription.EmailAddress };

                foreach (var entry in result)
                {
                    Console.WriteLine($"{entry.Summary}: {entry.EmailAddress}");
                }
            }
        }
        #endregion

        #region 模拟编译器对查询表达式的实现过程
        /// <summary>
        /// 创建一个数据源
        /// </summary>
        static void TryFakeQuery()
        {
            var result = from x in new FakeQuery<string>()
                         where x.StartsWith("abc")
                         select x.Length;

            foreach (var item in result) { }
        }
        /// <summary>
        /// 使用聚合运算符，立刻对结果进行计算会调用IQueryProvider.Execute()
        /// </summary>
        static void TryFakeQuery1()
        {
            var result = from x in new FakeQuery<string>()
                         where x.StartsWith("abc")
                         select x.Length;
            double mean = result.Average();

            foreach (var item in result) { }
        }
        #endregion

    }
}
