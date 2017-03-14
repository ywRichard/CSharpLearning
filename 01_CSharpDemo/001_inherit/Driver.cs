using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_inherit
{
    class Driver:Person
    {
        //司机：我叫舒马赫，年龄45 男人 驾龄23年
        int _driveTime;

        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

        public Driver(string name,int age, char gender, int driveTime):base(name,age,gender)
        {
            this.DriveTime = driveTime;
        }

        public void DriverSayHello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，我是{2}生，驾龄{3}年",this.Name,this.Age,this.Gender,this.DriveTime);
        }

        public new void SayHello()
        {
            Console.WriteLine("我是司机");
        }
    }
}
