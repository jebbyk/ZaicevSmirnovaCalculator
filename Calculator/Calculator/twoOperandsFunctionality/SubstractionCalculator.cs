namespace Calculator.twoOperandsFunctionality
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
