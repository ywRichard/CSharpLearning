using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Out参数练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.TryParse(string s,out num)
            //新建一个方法实现tryparse的功能
            Console.WriteLine("输入需要转换的字符");
            string str = Console.ReadLine();
            int num;
            //bool flag = MyTryParse(str, out num);
            //bool flag = MyTryParse(str, out num);
            bool flag = MyTryParse(str, out num);
            if (true == flag)
            {
                Console.WriteLine("转换成功：{0}", num);
            }
            else 
            {
                Console.WriteLine("输入的不是数字");
            }
            Console.ReadKey();

        }
        //public static bool MyTryParse(string input, out int number)
        //public static bool MyTryParse(string input,out int number)
        public static bool MyTryParse(string input, out int number)
        {
            try
            {
                number = Convert.ToInt32(input);
                return true;
            }
            catch 
            {
                number = 0;
                return false;
            }
            
        }

    }
}
