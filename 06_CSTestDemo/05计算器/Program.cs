using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace _05计算器
{
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
