using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _类的练习复习
{
    public class Person
    {

        //public static int High
        //{
        //    get { return Person.high; }
        //    set { Person.high = value; }
        //}

        //public static int High
        //{
        //    get { return Person.high; }
        //    set { Person.high = value; }
        //}
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person(string name,char gender):this(name,0,gender)
        {        
        }

        string _name;
        public string Name
        {
            get
            {
                if (_name != "悟空")
                {
                    _name = "悟空";
                }
                return _name;
            }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = -1;
                }
                _age = value;
            }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set 
            {
                if (value != '男' && value != '女')
                {
                    value = '*';
                }
                _gender = value; 
            }
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}，我是{2}生", this.Name, this.Age, this.Gender);
        }
    }
}
