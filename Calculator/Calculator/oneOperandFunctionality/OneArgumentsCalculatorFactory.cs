using System;

namespace Calculator.oneOperandFunctionality
{
    public static class OneArgumentsCalculatorFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new SinusCalculator();
                    break;
                case "Cos":
                    return new CosinusCalculator();
                    break;
                case "Sqrt":
                    return new SqrtCalculator();
                    break;
                case "Sqr":
                    return new SquareCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}
