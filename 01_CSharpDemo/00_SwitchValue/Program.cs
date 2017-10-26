using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_SwitchValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.	声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换，最后输出n1为20,n2为10。
            //扩展（*）：不使用第三个变量如何交换？
            Console.WriteLine("输入非数字类型的变量,输入a的值:");
            string a = Console.ReadLine();
            Console.WriteLine("输入b的值:");
            string b = Console.ReadLine();
            JiaoHuan(a, b);
            Console.ReadKey();

            Console.WriteLine("输入数字类型的变量，请输入a的值：");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入b的值：");
            int b1 = Convert.ToInt32(Console.ReadLine());
            NoMiddleVar(a1, b1);
            NoMiddleVar(ref a1, ref b1);
            Console.WriteLine("a={0},b={1}", a1, b1);

            Console.ReadKey();

        }

        /// <summary>
        /// 用中间变量交换两个变量
        /// </summary>
        public static void JiaoHuan(string a, string b)
        {
            string temp = "";
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a是{0}，b是{1}", a, b);
        }

        /// <summary>
        /// 不用中间类型交换两个变量，只能用于交换数值类型的变量
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void NoMiddleVar(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a={0},b={1}", a, b);
        }

        /// <summary>
        /// 用ref类型的参数，传递变量的值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void NoMiddleVar(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
