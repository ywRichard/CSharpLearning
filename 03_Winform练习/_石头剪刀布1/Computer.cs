using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _石头剪刀布1
{
    class Computer
    {
        public string Fist
        {
            get;
            set;
        }

        public int ShowFist()
        {
            Random random = new Random();
            int num = random.Next(1, 4);
            switch (num)
            {
                case 1: this.Fist = "石头";
                    break;
                case 2: this.Fist = "剪刀";
                    break;
                case 3: this.Fist = "布";
                    break;
                default:
                    break;
            }
            return num;
        }
    }
}
