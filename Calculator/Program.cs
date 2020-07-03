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
                var firstNumber = inputConverter.ConvertToNumber(Console.ReadLine());
                var secondNumber = inputConverter.ConvertToNumber(Console.ReadLine());
                //Read operator from console
                var operation = Console.ReadLine();

                //Perdom the calculation and print thr result to console
                var result = calculationEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
