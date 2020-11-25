using static System.Console;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculationEngine calculationEngine = new CalculationEngine();

                //Read two operands from console and convert it to double
                WriteLine("Enter first operand: ");
                var firstNumber = inputConverter.ConvertToNumber(ReadLine());
                WriteLine("Enter second operand: ");
                var secondNumber = inputConverter.ConvertToNumber(ReadLine());
                //Read operator from console
                WriteLine("Enter operator: ");
                var operation = ReadLine();

                //Perform the calculation and print thr result to console
                var result = calculationEngine.Calculate(operation, firstNumber, secondNumber);
                WriteLine(result);
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
        }
    }
}
