using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_GenericClass
{
    public class Chicken : Animal
    {
        public override string Name { get; set; }

        public Chicken(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("{0}啄着吃",Name);
        }

        public override void Shout()
        {
            Console.WriteLine("{0}嗝咯叫",Name);
        }
    }
}
