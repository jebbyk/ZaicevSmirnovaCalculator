﻿using System;

namespace Calculator.twoOperandsFunctionality
{
   public static class TwoArgumentsCalculatorFactory
    {
       public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new AddittionCalculator();
                    break;
                case "-":
                    return new SubstractionCalculator();
                    break;
                case "*":
                    return new MultiplyCalculator();
                    break;
                case "/":
                    return new DivisionCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}
