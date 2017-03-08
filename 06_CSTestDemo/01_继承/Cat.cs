using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_继承
{
    public class Cat:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("舔着吃");
        }

        public override void Shout()
        {
            Console.WriteLine("喵喵叫");
        }
    }
}
