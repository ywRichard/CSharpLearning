using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_inherit
{
    class Person
    {
        //记者：我是记者 爱好偷拍 年龄34岁 我是一个男狗仔

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
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

        public void SayHello()
        {
            Console.WriteLine("我是人");
        }
    }
}
