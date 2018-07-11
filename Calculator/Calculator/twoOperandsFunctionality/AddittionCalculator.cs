namespace Calculator.twoOperandsFunctionality
{
    public class AddittionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Addition function
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        ///Returns summ of two numbers
        /// /returns>
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
