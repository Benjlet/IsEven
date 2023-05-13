using NUnit.Framework;

namespace IsEven.Tests.Calculators
{
    public class IsEvenCalculatorBitwiseAmpersandTests
    {
        private const AlgorithmType TestAlgorithmType = AlgorithmType.BitwiseAmpersand;

        [Test]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(int.MinValue)]
        public void IsEven_WhereEven_ReturnsTrue(int testValue)
        {
            Assert.Multiple(() =>
            {
                Assert.That(IsEvenCalculator.IsEven(testValue, TestAlgorithmType));
                Assert.That(testValue.IsEven(TestAlgorithmType));
            });
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
            Assert.Multiple(() =>
            {
                Assert.That(IsEvenCalculator.IsEven(testValue, TestAlgorithmType), Is.False);
                Assert.That(testValue.IsEven(TestAlgorithmType), Is.False);
            });
        }

        [Test]
        [TestCase(0118999)]
        [TestCase(88199)]
        [TestCase(9119725)]
        [TestCase(3)]
        [TestCase(int.MaxValue)]
        [TestCase(-8675309)]
        public void IsOdd_WhereOdd_ReturnsTrue(int testValue)
        {
            Assert.Multiple(() =>
            {
                Assert.That(IsEvenCalculator.IsOdd(testValue, TestAlgorithmType));
                Assert.That(testValue.IsOdd(TestAlgorithmType));
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(int.MinValue)]
        public void IsOdd_WhereNotOdd_ReturnsFalse(int testValue)
        {
            Assert.Multiple(() =>
            {
                Assert.That(IsEvenCalculator.IsOdd(testValue, TestAlgorithmType), Is.False);
                Assert.That(testValue.IsOdd(TestAlgorithmType), Is.False);
            });
        }

        [Test]
        [TestCase(0118999)]
        [TestCase(88199)]
        [TestCase(9119725)]
        [TestCase(3)]
        [TestCase(int.MaxValue)]
        [TestCase(-8675309)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(int.MinValue)]
        public void IsOddOrEvent_WhereOddOrEven_ReturnsTrue(int testValue)
        {
            Assert.Multiple(() =>
            {
                Assert.That(IsEvenCalculator.IsOddOrEven(testValue));
                Assert.That(testValue.IsOddOrEven());
            });
        }
    }
}