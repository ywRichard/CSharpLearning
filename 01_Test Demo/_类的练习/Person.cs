using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _类的练习
{
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        private int _age;
        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            {
                if (value < 0 || value > 100)
                {
                    value = -1;
                }
                _age = value; 
            }
        }
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}
        char _gender;
        public char Gender
        {
            get 
            {
                if(_gender!='男'&&'女'!=_gender)
                {
                    _gender = '*';
                }
                return _gender; 
            }
            set { _gender = value; }
        }
        //public char Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}
        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
            Console.ReadKey();
        }
    }
}
