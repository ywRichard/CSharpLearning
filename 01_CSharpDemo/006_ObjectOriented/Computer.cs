using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_ObjectOriented
{
    public class Computer
    {
        public string FistName { get; set; }

        public int Play()
        {
            int num = 0;
            Random rd=new Random();
            num = rd.Next(1,4);

            switch (num)
            {
                case 1: this.FistName = "石头"; break;
                case 2: this.FistName = "剪刀"; break;
                case 3: this.FistName = "布"; break;
                default:
                    break;
            }

            return num;
        }
    }
}
