using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_GenericClass
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Eat();
        public abstract void Shout();

        protected string Test()
        {
            return "Test if abstract class can exist non-abstract member.";
        }
    }
}
