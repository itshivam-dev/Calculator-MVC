using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Calculator calc = new Calculator();
            int result = calc.Subtract(5, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Calculator calc = new Calculator();
            int result = calc.Multiply(2, 3);

            Assert.AreEqual(6, result);
        }
    }
}