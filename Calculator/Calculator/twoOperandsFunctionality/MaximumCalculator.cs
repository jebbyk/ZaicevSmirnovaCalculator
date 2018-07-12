namespace Calculator.twoOperandsFunctionality
{
    public class MaximumCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Maximum function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// takes two doubles
        /// <returns>
        /// Returns number that more then other
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }
    }
}
