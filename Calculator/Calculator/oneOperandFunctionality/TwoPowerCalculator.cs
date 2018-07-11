﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    class TwoPowerCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}