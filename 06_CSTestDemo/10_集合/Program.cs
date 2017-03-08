using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _10_集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "老虎", Age = 10, Gender = '男' });
            list.Add(new Person() { Name = "老鼠", Age = 12, Gender = '女' });
            list.Add(new Person() { Name = "老狼", Age = 9, Gender = '女' });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);   
            }

            Console.ReadLine();
        }
    }

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

        /// <summary>
        /// 重写ToString函数
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
