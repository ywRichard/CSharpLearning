using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26_委托之匿名和拉姆达
{
    class Program
    {
        //public delegate void MyDel();
        //public delegate void MyDel(string str);
        public delegate string MyDel(string str);
        public delegate void MyDel_1();
        static void Main(string[] args)
        {
            //MyDel mdl = Show;//委托
            
            //MyDel mdl = delegate(string msg) { Console.WriteLine(msg); };//匿名方法
            //MyDel mdl = (string msg) => { Console.WriteLine(msg); };//简化的匿名方法
            //T1(x => x + "语法", "拉姆达表达式");//拉姆达表达式
            T2(()=>Console.WriteLine("无参数"),"拉姆达表达式");//无参拉姆达表达式
            //mdl();
            //mdl("匿名方法的语法");
            Console.ReadKey();
        }

        public static void Show()
        {
            Console.WriteLine("委托的语法");
        }

        public static void T1(MyDel mdl, string str)
        {
            string msg = mdl(str);
            Console.WriteLine(msg);
        }

        public static void T2(MyDel_1 mdl,string str)
        {
            mdl();
            Console.WriteLine(str);
        }
    }
}
