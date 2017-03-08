using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_石头剪刀布
{
    public class Fist
    {
        public string FistName { get; set; }

        public int Play()
        {
            int num = 0;
            string name = this.FistName;
            switch (name)
            {
                case "石头": num = 1; break;
                case "剪刀": num = 2; break;
                case "布": num = 3; break;
                default:
                    break;
            }
            return num;
        }
    }
}
