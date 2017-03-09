using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_InheritClass
{
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("咬着吃");
        }

        public override void Shout()
        {
            Console.WriteLine("汪汪叫");
        }
    }
}
