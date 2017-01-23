using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _重写ToString方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }

    public class Person
    {
        public override string ToString()
        {
            return "Hello World!";
        }
    }
}
