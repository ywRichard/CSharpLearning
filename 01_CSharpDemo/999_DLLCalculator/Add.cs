﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Add:Cal
    {
        public Add(int n1, int n2)
            : base(n1, n2)
        { }
        public override int GetResult()
        {
            return this.Num1 + this.Num2;
        }
    }
}