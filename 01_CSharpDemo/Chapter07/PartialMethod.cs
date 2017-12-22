using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    partial class PartialMethod
    {
        public PartialMethod()
        {
            OnConstructorStart();//没有任何实现的部分方法，编译器会把他移除
            Console.WriteLine("Generated Constructor");
            OnConstructorEnd();
        }

        partial void OnConstructorStart();
        partial void OnConstructorEnd();
    }

    partial class PartialMethod
    {
        partial void OnConstructorEnd()
        {
            Console.WriteLine("Manual code");
        }
    }
}
