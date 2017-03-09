using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public abstract class Cal
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public Cal(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public Cal()
        {
            // TODO: Complete member initialization
        }

        public abstract int GetResult();
    }
}
