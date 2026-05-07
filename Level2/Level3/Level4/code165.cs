using NUnit.Framework;

namespace NUnitDemo
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Test()
        {
            Calculator c = new Calculator();

            int result = c.Add(10, 5);

            Assert.AreEqual(15, result);
        }
    }
}