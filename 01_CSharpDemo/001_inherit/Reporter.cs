using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_inherit
{
    class Reporter : Person
    {
        string _hobby;

        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public Reporter(string name, int age, char gender, string hobby)
            : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        public void ReportSayHello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，我是{2}生，我的爱好{3}",this.Name,this.Age,this.Gender,this.Hobby);
        }
        public new void SayHello()
        {
            Console.WriteLine("我是记者");
        }
    }
}
