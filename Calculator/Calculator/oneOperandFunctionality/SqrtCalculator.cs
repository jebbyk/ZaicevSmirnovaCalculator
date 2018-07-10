using System;

namespace Calculator.oneOperandFunctionality
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
