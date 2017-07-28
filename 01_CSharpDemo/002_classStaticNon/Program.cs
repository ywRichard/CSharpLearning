using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Class
{
    /// <summary>
    #region MyRegion
    //静态类和非静态类的区别
    //1、在非静态类中，既可以有实例（非静态　）成员，也可以有静态成员。
    //    在调用实例成员的时候，需要使用”对象名.实例成员“。
    //    在调用静态成员的时候，需要使用“类名．静态成员名。
    //    总结：静态成员必须使用类名去调用，实例成员使用对象名调用。
    //        静态函数中，只能访问静态成员，不允许访问实例成员。
    //        实例函数中，即可以使用静态成员，也可以使用实例成员。
    //2、静态类：只允许有静态成员，不允许有实例成员。静态类不允许实例化。
    //            使用范围：1、作为”工具类“，可以考虑用静态类。
    //                        2、静态类在整个项目中资源共享。
    //            只有在程序全部结束之后，静态类才会释放资源。
    #endregion
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
