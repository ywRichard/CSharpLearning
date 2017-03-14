using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MedOverride
{
    /// <summary>
    /// 重写.Net框架下的方法
    /// </summary>
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
