using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolyOfSimpleFactory
{
    /// <summary>
    /// 文件案例:了解简单工厂模式，加深理解多态的概念。
    /// 通过抽象类实现
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文件名");
            string fileName = Console.ReadLine();

            string[] shortName = fileName.Split('.');

            string suffix=shortName[shortName.Length-1];

            CustomFile cf = OpenType(suffix);

            Console.WriteLine(cf.OpenFile());

            Console.ReadLine();
        }

        private static CustomFile OpenType(string name)
        {
            CustomFile cf = null;
            switch (name)
            {
                case "txt": cf = new Txt_File(); break;
                case "jpg": cf = new jpg_File(); break;
                case "avi": cf = new avi_File(); break;
                default: 
                    break;
            }

            return cf;
        }
    }
}
