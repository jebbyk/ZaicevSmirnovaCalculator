namespace Calculator.twoOperandsFunctionality
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// Takes two doubles
        /// <returns>
        /// Returns result of multiplying first number by second number
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
