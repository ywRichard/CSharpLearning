using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _017_Serialize
{
    /// <summary>
    /// 序列化和反序列化，作用：传递数据
    /// 序列化：将对象转化为二进制。
    /// 反序列化：将二进制转化为对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age=18;
            //p.Gender='男';

            //using (FileStream fsWrite = new FileStream(@"C:\Users\Richard\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    //开始序列化
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}

            //Console.WriteLine("序列化成功！");
            //Console.ReadKey();

            Person p;

            using (FileStream fsRead = new FileStream(@"C:\Users\Richard\Desktop\new.txt", FileMode.Open, FileAccess.Read))
            {
                //开始反序列化
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
