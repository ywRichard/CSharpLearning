using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019_Initializer
{
    /// <summary>
    /// 初始化器
    /// 初始化器在Linq中用的比较多，匿名对象
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //ObjectInitializer();

            #region Anonymous Type Inilializer
            //var per = new { Name = "WangWang", Age = 19 };//用初始化器创建一个匿名类,匿名类的属性全为只读

            //var students = new List<Student> 
            //{
            //    new Student{FirstName="Wang",LastName="Meimei"},
            //    new Student{FirstName="Li",LastName="Ming"},
            //    new Student{FirstName="Han",LastName="Xing"}
            //};

            //var studentsFrom = new List<StudentFrom>
            //{
            //    new StudentFrom{FirstName="Han",City="Zhao"},
            //    new StudentFrom{FirstName="Zhang",City="SH"},
            //    new StudentFrom{FirstName="Huang",City="Beijing"}
            //};

            //var joinquery = from s in students
            //                join f in studentsFrom on s.FirstName equals f.FirstName
            //                select new { FirstName = s.FirstName, LastName = s.LastName, City = f.City };

            //foreach (var stu in joinquery)
            //{
            //    Console.WriteLine("FirstName:{0}, LastName:{1}, City={2}",stu.FirstName,stu.LastName,stu.City);
            //}
            #endregion

            #region Collection Initializer
            var students = new List<Student>
            {
                new Student{FirstName="Zhang",LastName="Liang",ID=100},
                new Student{FirstName="Han",LastName="Xing",ID=101},
                new Student{FirstName="Fan",LastName="Kuai",ID=102}
            };

            foreach (var stu in students)
            {
                Console.WriteLine(stu.FirstName+":"+stu.LastName);
            }

            Dictionary<int, Student> dictStudents = new Dictionary<int, Student>
            {
                {200,new Student{FirstName="Xiang",LastName="Yu",ID=200}},
                {201,new Student{FirstName="Yu",LastName="Ji",ID=201}},
                {202,new Student{FirstName="Peng",LastName="Fu",ID=202}}
            };

            foreach (var stu in dictStudents)
            {
                Console.WriteLine(stu.Key+":"+stu.Value.FirstName+stu.Value.LastName);
            }

            #endregion

            Console.ReadLine();
        }

        private static void ObjectInitializer()
        {
            Student stu1 = new Student("Yao", "Ming");//构造函数
            Console.WriteLine(stu1.ToString());
            Student stu2 = new Student { FirstName = "Li", LastName = "Lei", ID = 100 };//类的初始化器
            Console.WriteLine(stu2.ToString());
            Student stu3 = new Student("Liu", "Ming") { ID = 200 };
            Console.WriteLine(stu3.ToString());
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return this.FirstName + " : " + this.ID;
        }
    }

    public class StudentFrom
    {
        public string FirstName { get; set; }
        public string City { get; set; }
    }
}
