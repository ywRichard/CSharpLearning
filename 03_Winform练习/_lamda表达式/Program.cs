using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _lamda表达式
{
    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //lamda表达式和匿名函数
            DelOne delOne = () => { };//delegate() { };
            DelTwo deTwo = (string name) => { };//delegate(string name) { };
            DelThree delThree = (string name) => { return name; };//delegate(string name) { return name; };

            List<int> list=new List<int>{1,2,3,4,5,6,7,8,9,0};
            list.RemoveAll(n=>n<4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
