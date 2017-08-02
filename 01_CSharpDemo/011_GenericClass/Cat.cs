using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_GenericClass
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("{0}说舔着吃",Name);
        }


        public override void Shout()
        {
            Console.WriteLine("{0}喵喵叫",Name);
        }
    }
}
