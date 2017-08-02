using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_GenericClass
{
    class SuperDog : Dog
    {

        public SuperDog(string name)
            : base(name)
        {

        }

        public override void Shout()
        {
            Console.WriteLine("{0} 朝太阳叫", Name);
        }

        public void Fly()
        {
            Console.WriteLine("{0} 能飞", Name);
        }
    }
}
