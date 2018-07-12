namespace Calculator.twoOperandsFunctionality
{
    public class ArithmeticMeanCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Arithmetical mean function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// takes two doubles
        /// <returns>
        /// returns an arithmetical mean of two numbers
        /// </returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber)/2;
        }
    }
}
