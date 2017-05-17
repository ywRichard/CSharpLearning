using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_AbstractOfMoblieDevice
{
    /// <summary>
    /// 移动设备读取案例
    /// 抽象类的继承使用，类可以嵌套调用。即类可以当作变量赋值给其他的属性或者字段。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Computer cp = new Computer();
            cp.SD = new MP3();
            cp.Write();
            cp.Read();
            Console.ReadLine();
        }
    }
}
