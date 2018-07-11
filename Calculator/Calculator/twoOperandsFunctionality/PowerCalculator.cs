﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    public class PowerCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
