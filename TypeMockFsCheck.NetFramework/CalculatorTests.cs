using System;
using FsCheck.Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TypeMockFsCheck.NetFramework
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSum()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(3, 5);

            Assert.AreEqual(8, result);
        }
    }

    public class XUnitCalculatorTests
    {
        [Fact]
        public void ResultIsSumOfParts()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(3, 5);

            Assert.AreEqual(8, result);
        }
    }

    public class FsCheckCalculatorTests
    {
        [Property]
        public void SumIsGreaterThanParts(int a, int b)
        {
            var calculator = new Calculator();

            var result = calculator.Sum(a, b);

            Assert.IsTrue(result > a);
            Assert.IsTrue(result > b);
        }
    }
}
