using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace Calculator.Test.Unit
{    
    [TestClass]
    public class CalculationEngineTest
    {
        CalculationEngine _calculationEngine=new CalculationEngine();
        [TestMethod]
        public void AddTwoNumbersAndReturnValidResult()
        {
            double firstNumber=2;
            double secondNumber=6;
            Assert.AreEqual(8,_calculationEngine.Calculate("+",firstNumber,secondNumber));
        }

        [TestMethod]
        public void SubtractTwoNumbersAndReturnValidResult()
        {
            double firstNumber=2;
            double secondNumber=6;
            Assert.AreEqual(-4,_calculationEngine.Calculate("-",firstNumber,secondNumber));
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnValidResult()
        {
            double firstNumber=2;
            double secondNumber=6;
            Assert.AreEqual(12,_calculationEngine.Calculate("*",firstNumber,secondNumber));
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnValidResult()
        {
            double firstNumber=10;
            double secondNumber=4;
            Assert.AreEqual(2.5,_calculationEngine.Calculate("/",firstNumber,secondNumber));
        }

        [TestMethod]
        public void InvalidOperationInputThrowsException(){
            double firstNumber=2;
            double secondNumber=6;
            Assert.ThrowsException<InvalidOperationException>(()=>
            _calculationEngine.Calculate(".",firstNumber,secondNumber));
        }
    }
}
