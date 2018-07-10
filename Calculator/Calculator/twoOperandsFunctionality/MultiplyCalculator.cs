namespace Calculator.twoOperandsFunctionality
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
