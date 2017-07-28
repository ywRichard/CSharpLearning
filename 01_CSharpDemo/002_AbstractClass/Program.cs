using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace _05计算器
{
    /// <summary>
    /// 计算器案例，抽象类的使用。
    /// 建立抽象计算类，封装加减乘除等计算方法继承与该抽象类。
    /// 复习将方法封装成类，将多个类封装成类库，生成DLL调用。
    /// 另外还有构造函数的继承。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请选择运算符+，-，*");
            string opt = Console.ReadLine();

            Cal cal = SelectToCal(opt,num1,num2);

            if (cal!=null)
            {
                Console.WriteLine(cal.GetResult().ToString());
            }
            else
            {
                Console.WriteLine("计算失败");
            }

            Console.ReadLine();
        }

        private static Cal SelectToCal(string opt, int num1, int num2)
        {
            Cal cal = null;
            switch (opt)
            {
                case "+": cal = new Add(num1, num2); break;
                case "-": cal = new Sub(num1, num2); break;
                case "*": cal = new Multiple(num1, num2); break;
                default: ;
                    break;
            }

            return cal;
        }
    }
}
