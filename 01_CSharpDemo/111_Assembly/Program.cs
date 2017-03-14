using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _31_关于程序集
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person();

            //Type tp = ps.GetType();//通过对象获得类的类型
            Type tp = typeof(Person);//通过类获得该类型

            ConstructorInfo[] ci = tp.GetConstructors();

            Console.WriteLine("**********GetConstructors**********");
            foreach (var item in ci)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("**********GetEvents**********");

            EventInfo[] ei = tp.GetEvents();
            foreach (var item in ei)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("**********GetMembers**********");

            MemberInfo[] mi = tp.GetMembers();
            foreach (var item in mi)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("**********GetMethods**********");

            MethodInfo[] mth = tp.GetMethods();
            foreach (var item in mth)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("**********GetProperties**********");

            PropertyInfo[] pros = tp.GetProperties();
            foreach (var item in pros)
            {
                Console.WriteLine();
            }
            Console.WriteLine("**********End**********");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public Person()
        {
            this.Name = "Stark";
            this.Age = 23;
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static void SayHello()
        { 
         Console.WriteLine("I'm XXX");
        }
    }
}
