﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.twoOperandsFunctionality
{
    class ModulaCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}
