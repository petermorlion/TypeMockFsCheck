using System;
using Xunit;

namespace TypeMockFsCheck.XUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void TestSum()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(3, 5);

            Assert.Equal(8, result);
        }
    }
}
