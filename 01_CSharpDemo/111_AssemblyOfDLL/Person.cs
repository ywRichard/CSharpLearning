using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _MyClass
{
    public class Person: Animal,IFly
    {
        public int Age { get; set; }

        public void SaySth()
        {
            Console.WriteLine("Say Something");
        }

        public override void eatSth()
        {
            Console.WriteLine("Eat Something");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
