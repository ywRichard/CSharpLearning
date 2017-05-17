using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _MyClass
{
    public class Student: Person
    {
        public string Number { get; set; }

        public void DoSth()
        {
            Console.WriteLine("升国旗");
        }
    }
}
