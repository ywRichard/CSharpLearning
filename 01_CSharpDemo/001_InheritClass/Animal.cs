using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_InheritClass
{
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Shout();

        protected string Test()
        {
            return "Test Abstract";
        }
    }
}
