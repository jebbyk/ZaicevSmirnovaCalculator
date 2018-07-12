using System;

namespace Calculator.twoOperandsFunctionality
{
   public static class TwoArgumentsCalculatorFactory
    {
       public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new AddittionCalculator();
                    break;
                case "-":
                    return new SubstractionCalculator();
                    break;
                case "*":
                    return new MultiplyCalculator();
                    break;
                case "/":
                    return new DivisionCalculator();
                    break;
                case "Arith Mean":
                    return new ArithmeticMeanCalculator();
                    break;
                case "x^y":
                    return new PowerCalculator();
                    break;
                case "Max":
                    return new MaximumCalculator();
                    break;
                case "Min":
                    return new MinimumCalculator();
                    break;
                case "x^(1/y)":
                    return new AdvansedRootCalculator();
                    break;
                case "x%y":
                    return new ModulaCalculator();
                    break;
                case "Rad":
                    return new RadiusCalculator();
                    break;
                case "Geom Mean":
                    return new GeometricMeanCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}
