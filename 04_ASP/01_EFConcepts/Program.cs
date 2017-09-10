using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace _01_EFConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new SchoolDBEntities())
            //{
            //    var objectContext = (ctx as IObjectContextAdapter).ObjectContext;

            //    //Console.WriteLine(objectContext);
            //    //Console.WriteLine(objectContext.ToString());

            //    //ctx.Configuration.ProxyCreationEnabled = true;

            //    var studentEntity = ctx.Student.FirstOrDefault<Student>();//查询操作，不改变Entity实例的状态
            //    Console.WriteLine(studentEntity.GetType());
            //    Console.WriteLine(ObjectContext.GetObjectType(studentEntity.GetType()));

            //    ctx.Student.Add(new Student { StudentID=2,StudentName = "Logic1" });
            //    ctx.SaveChanges();
            //}

            using (var ctx=new SchoolDBEntities1())
            {
                //ctx.Students.Add(new Student { StudentName="Logic"});

                var studentEntity = ctx.Students.FirstOrDefault<Student>();
                studentEntity.StudentName = "Li";//更改一个行的StudentName

                ctx.Students.Remove(studentEntity);//删除Student中的第一行数据

                ctx.SaveChanges();

                Console.WriteLine("ok");
            }

            Console.ReadLine();
        }
    }
}
