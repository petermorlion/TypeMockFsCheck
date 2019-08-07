using NUnit.Framework;

namespace TypeMockFsCheck.NUnit
{
    public class CalculatorTests
    {
        [Test]
        public void TestSum()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(3, 5);

            Assert.AreEqual(8, result);
        }
    }
}