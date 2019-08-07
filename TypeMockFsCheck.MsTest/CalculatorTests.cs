using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeMockFsCheck.MsTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSum()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(3, 5);

            Assert.Equals(8, result);
        }
    }
}
