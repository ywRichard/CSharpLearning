using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_InheritClass
{
    public class Chicken:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("啄着吃");
        }

        public override void Shout()
        {
            Console.WriteLine("嗝咯叫");
        }
    }
}
