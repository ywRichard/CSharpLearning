using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06文件案例
{
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
