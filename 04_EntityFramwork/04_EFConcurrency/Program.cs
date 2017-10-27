using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EFConcurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateEntity();

            //并发处理->EF会按时间顺序发送修改指令。
            //如果修改的是不同的字段，则没有影响；如果修改的是相同的字段，最后一次会覆盖前面的修改。
            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);
            Console.WriteLine("完成");
        }

        public static Task t1 = new Task(() =>
        {
            using (DbContext context = new MyContext())
            {
                var p = context.Set<Person>().FirstOrDefault();
                p.Description = $"Description Modified at{DateTime.Now.ToShortTimeString()}";

                context.SaveChanges();
            }
        });

        public static Task t2 = new Task(() =>
        {
            using (DbContext context = new MyContext())
            {
                var p = context.Set<Person>().FirstOrDefault();
                p.Age *= 2;
                p.Description = "000";
                context.SaveChanges();
            }
        });

        public static void CreateEntity()
        {
            using (DbContext context = new MyContext())
            {
                var people = new List<Person>
                {
                    new Person{ Age=10,Name="张三",Description="111111"},
                    new Person{Age=15,Name="李四",Description="222222"}
                };

                context.Set<Person>().AddRange(people);
                var result = "Create Entity " + (context.SaveChanges() > 0 ? "Ok" : "NG");
                Console.WriteLine(result);
            }
        }
    }
}
