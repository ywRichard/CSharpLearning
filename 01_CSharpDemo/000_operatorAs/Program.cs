using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_operatorAs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 失效的显式转换
            ClassA obj1 = new ClassA();
            ClassB obj = obj1 as ClassB;//为什么值为null
            #endregion

            #region as实例
            //ClassB b = new ClassB();
            //ClassA a = b;
            //ClassB obj = a as ClassB;
            #endregion
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("obj is nuull");
        }
    }

    public interface IMyInterface
    {

    }
    class ClassA : IMyInterface
    {

    }
    class ClassB : ClassA
    {
        public override string ToString()
        {
            return "I'm an instance";
        }
    }
}
