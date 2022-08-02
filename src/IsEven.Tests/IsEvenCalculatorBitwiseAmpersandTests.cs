using NUnit.Framework;

namespace IsEven.Tests
{
    public class IsEvenCalculatorBitwiseAmpersandTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(int.MinValue)]
        public void IsEven_WhereEven_ReturnsTrue(int testValue)
        {
            Assert.That(
                new IsEvenCalculatorBitwiseAmpersand().IsEven(testValue));
        }

        [Test]
        [TestCase(0118999)]
        [TestCase(88199)]
        [TestCase(9119725)]
        [TestCase(3)]
        [TestCase(int.MaxValue)]
        [TestCase(-8675309)]
        public void IsEven_WhereNotEven_ReturnsFalse(int testValue)
        {
            Assert.That(
                new IsEvenCalculatorBitwiseAmpersand().IsEven(testValue), Is.False);
        }
    }
}