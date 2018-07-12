namespace Calculator.twoOperandsFunctionality
{
    public class MinimumCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Minimum function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// takes two doubles
        /// <returns>
        /// returns number that is less then other
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber ? secondNumber : firstNumber;
        }
    }
}
