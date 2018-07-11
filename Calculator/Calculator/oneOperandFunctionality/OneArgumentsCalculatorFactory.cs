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
                case "-x":
                    return new NegativeCalculator();
                    break;
                case "10^x":
                    return new TenPowerCalculator();
                    break;
                case "2^x":
                    return new TwoPowerCalculator();
                    break;
                case "Tan":
                    return new TangentCalculator();
                    break;
                case "Arcsin":
                    return new ArcsinusCalculator();
                    break;
                case "Arccos":
                    return new ArccosinusCalculator();
                    break;
                case "Ln":
                    return new NatLnCalculator();
                    break;
                default:
                    throw new Exception("error");
            }
        }
    }
}
