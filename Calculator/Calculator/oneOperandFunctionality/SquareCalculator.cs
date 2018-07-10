namespace Calculator.oneOperandFunctionality
{
    public class SquareCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstNumber)
        {
            return firstNumber*firstNumber;
        }
    }
}
