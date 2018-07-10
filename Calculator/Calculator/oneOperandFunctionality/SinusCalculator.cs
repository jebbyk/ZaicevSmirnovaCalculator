using System;

namespace Calculator.oneOperandFunctionality
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return Math.Sin(firstNumber);
        }
    }
}
