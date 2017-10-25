using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _09_序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "和尚";
            //p.Age = 12;
            
            //using (FileStream fs = new FileStream("1.txt",FileMode.Create,FileAccess.Write))
            //{
            //    //创建序列化器
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs,p);
            //}

            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //反序列化
            Object Obj = new Object();
            using (FileStream fs = new FileStream("1.txt",FileMode.Open,FileAccess.Read))
            {
                //创建反序列化器
                BinaryFormatter bf = new BinaryFormatter();
                Obj = bf.Deserialize(fs);
            }

            Person p = Obj as Person;
            Console.WriteLine(p.Name+p.Age.ToString());
            Console.WriteLine("反序列化成功");
            Console.ReadKey();
        }
    }
}
