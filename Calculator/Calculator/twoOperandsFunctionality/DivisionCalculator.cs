namespace Calculator.twoOperandsFunctionality
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}