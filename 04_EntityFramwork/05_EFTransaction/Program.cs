using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EFTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbContext context = new MyContext())
            {
                //AddEntity(context);
                UpdateEntityByTransction(context);
            }
        }

        public static void AddEntity(DbContext context)
        {

            context.Set<Class>().Add(new Class
            {
                Teacher = "Lily",
                ClassRoom = "302",
                CourseName = "English",
                Date = DateTime.Now.Date
            });
            context.SaveChanges();

            var englishClass = context.Set<Class>().Where(n => n.CourseName == "English").FirstOrDefault();
            if (englishClass != null)
            {
                englishClass.Student.Add(new Student
                {
                    Name = "张三",
                    Age = 10,
                });
            }
            context.SaveChanges();
        }

        public static void UpdateEntityByTransction(DbContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    //var course = context.Set<Class>().Where(n => n.CourseName == "English").FirstOrDefault();
                    //if (course != null)
                    //{
                    //    course.Teacher = "Rabbie1";
                    //    context.SaveChanges();

                    //    course.Date = DateTime.Today.AddDays(-10);
                    //    context.SaveChanges();

                    //    throw new Exception("抛个异常");

                    //    transaction.Commit();//如果不调用该函数，SQL指令会发送但是数据库不会更新。
                    //}
                    throw new Exception("抛个异常");
                }
                catch (Exception)
                {
                    //调用RollbaCK()，必须在Commit()之前，否则会抛异常。Commit之后，会释放这个Transaction,在调用就会抛异常。
                    transaction.Rollback();
                    throw;
                }

            }
        }
    }
}
