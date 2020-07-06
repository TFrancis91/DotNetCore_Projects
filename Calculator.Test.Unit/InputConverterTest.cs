using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringToNumber()
        {
            Assert.AreEqual(8, _inputConverter.ConvertToNumber("8"));
        }

        [TestMethod]
        public void FailsToConvertInvalidStringToNumber()
        {
            Assert.ThrowsException<ArgumentException>(()=>_inputConverter.ConvertToNumber("Eight"));
        }
    }
}