﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.oneOperandFunctionality
{
    class NegativeCalculator : IOneArgumentCalculator
    {
    public double Calculate(double firstNumber)
          {
             return -(firstNumber);
          }
    }
}