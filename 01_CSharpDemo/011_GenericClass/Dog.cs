using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_GenericClass
{
    class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("{0}咬着吃",Name);
        }

        public override void Shout()
        {
            Console.WriteLine("{0}汪汪叫",Name);
        }
    }
}
