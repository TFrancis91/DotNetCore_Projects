using System;

namespace Calculator
{
    public class CalculationEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Operation is not supported");
            }

            return result;
        }
    }
}