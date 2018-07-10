using System;

namespace Calculator.oneOperandFunctionality
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}