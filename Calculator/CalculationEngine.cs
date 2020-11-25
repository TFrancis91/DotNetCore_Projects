using System;

namespace Calculator
{
    public class CalculationEngine
    {
        //Using switch expression introduced in C# 8.0
        public double Calculate(string operation, double firstNumber, double secondNumber) =>
            operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                _ => throw new InvalidOperationException("Operation is not supported")
            };
    }
}