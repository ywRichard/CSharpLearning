using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_InheritClass
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
            Console.WriteLine(this.Test());
        }
    }
}
