using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_inherit
{
    class Programmer:Person
    {
        //程序员：我叫孙权 年龄44 男生 工作年限3年
        int _workTime;

        public int WorkTime
        {
            get { return _workTime; }
            set { _workTime = value; }
        }

        public Programmer(string name,int age,char gender,int workTime)
            : base(name,age,gender)
        {
            this.WorkTime = workTime;
        }

        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生，我的工龄{3}",this.Name,this.Age,this.Gender,this.WorkTime);
        }

        public new void SayHello()
        {
            Console.WriteLine("我是程序猿");
        }
    }
}
