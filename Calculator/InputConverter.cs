using System;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertToNumber(string input)
        {
            double result;

            if (!double.TryParse(input, out result)) throw new ArgumentException("Input is not a number");

            return result;
        }
    }
}