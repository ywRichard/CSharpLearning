using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_委托案例
{
    public delegate void MyDel();

    class Student
    {
        public void DoSth(MyDel mdl)
        {
            Console.WriteLine("吃早饭");
            mdl();
            Console.WriteLine("吃午饭");
        }
    }
}
