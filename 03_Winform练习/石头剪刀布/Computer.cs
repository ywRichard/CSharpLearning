using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 石头剪刀布
{
    class Computer
    {
        public string strFist
        {
            get;
            set;
        }

        public int Fist()
        {            
            Random random = new Random();
            int num = random.Next(1, 4);
            switch (num)
            {
                case 1: this.strFist = "石头";
                    break;
                case 2: this.strFist = "剪刀";
                    break;
                case 3: this.strFist = "布";
                    break;
            }
            return num;
        }
    }
}
