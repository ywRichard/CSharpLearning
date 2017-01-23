using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _委托的练习
{
    //声明一个委托，必须和指向的方法具有相同的签名
    public delegate void DelSayHello(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHello del = new DelSayHello(EnglishSayHello);
            //DelSayHello del = new DelSayHello(ChineseSayHello);
            //DelSayHello del = EnglishSayHello;
            //DelSayHello del = ChineseSayHello;
            //del("张三");
            //Test("张三",EnglishSayHello);
            Test("张三",ChineseSayHello);
            
            Console.ReadKey();
            
        }

        public static void Test(string name, DelSayHello del)
        {
            del(name);
        }
        public static void EnglishSayHello(string name)
        {
            Console.WriteLine("Nice to meet you"+name);
        }

        public static void ChineseSayHello(string name)
        {
            Console.WriteLine("你好吗？"+name);
        }
    }
}
