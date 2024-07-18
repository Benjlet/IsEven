using IsEven.Tests.Models;
using NUnit.Framework;
using System.Numerics;

namespace IsEven.Tests.Calculators
{
    public class FloatingPointTests
    {
        [Test]
        [TestCase(100.25f)]
        [TestCase(900.5f)]
        [TestCase(0f)]
        public void Float_BehavesSameAsDotNet<T>(T number) where T : INumber<T>
        {
            IsEvenClient sut = new();

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                bool isEvenInteger = T.IsEvenInteger(number);
                bool isOddInteger = T.IsOddInteger(number);
                bool isInteger = T.IsInteger(number);

                Assert.That(sut.IsEven(number, algorithmType), Is.EqualTo(isEvenInteger));
                Assert.That(sut.IsOddOrEven(number, algorithmType), Is.EqualTo(isInteger));
                Assert.That(sut.IsOdd(number, algorithmType), Is.EqualTo(isOddInteger));
            }
        }

        [Test]
        [TestCase(100.25d)]
        [TestCase(900.5d)]
        [TestCase(0d)]
        public void Double_BehavesSameAsDotNet<T>(T number) where T : INumber<T>
        {
            IsEvenClient sut = new();

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                bool isEvenInteger = T.IsEvenInteger(number);
                bool isOddInteger = T.IsOddInteger(number);
                bool isInteger = T.IsInteger(number);

                Assert.That(sut.IsEven(number, algorithmType), Is.EqualTo(isEvenInteger));
                Assert.That(sut.IsOddOrEven(number, algorithmType), Is.EqualTo(isInteger));
                Assert.That(sut.IsOdd(number, algorithmType), Is.EqualTo(isOddInteger));
            }
        }

        [Test]
        public void Decimal_BehavesSameAsDotNet()
        {
            IsEvenClient sut = new();

            decimal decimalValue = 2.1m;

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                bool isEvenInteger = decimal.IsEvenInteger(decimalValue);
                bool isOddInteger = decimal.IsOddInteger(decimalValue);
                bool isInteger = decimal.IsInteger(decimalValue);

                Assert.That(sut.IsEven(decimalValue, algorithmType), Is.EqualTo(isEvenInteger));
                Assert.That(sut.IsOddOrEven(decimalValue, algorithmType), Is.EqualTo(isInteger));
                Assert.That(sut.IsOdd(decimalValue, algorithmType), Is.EqualTo(isOddInteger));
            }
        }

        [Test]
        [TestCase(100.25f)]
        [TestCase(900.5f)]
        [TestCase(0f)]
        public void IsEven_AllowsNonInteger_EvenFloat_ReturnsEven(float floatValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true,
                IgnoreDecimalDigits = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(floatValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(floatValue, algorithmType));
                    Assert.That(sut.IsOdd(floatValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase(101.25f)]
        [TestCase(901.5f)]
        [TestCase(1f)]
        public void IsEven_AllowsNonInteger_DecimalIgnored_OddFloat_ReturnsNotEven(float floatValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true,
                IgnoreDecimalDigits = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.That(sut.IsEven(floatValue, algorithmType), Is.False);
                Assert.That(sut.IsOddOrEven(floatValue, algorithmType));
                Assert.That(sut.IsOdd(floatValue, algorithmType));
            }
        }

        [Test]
        [TestCase(100.25d)]
        [TestCase(900.5d)]
        [TestCase(0d)]
        public void IsEven_AllowsNonInteger_DecimalIgnored_EvenDouble_ReturnsEven(double doubleValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true,
                IgnoreDecimalDigits = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.That(sut.IsEven(doubleValue, algorithmType));
                Assert.That(sut.IsOddOrEven(doubleValue, algorithmType));
                Assert.That(sut.IsOdd(doubleValue, algorithmType), Is.False);
            }
        }

        [Test]
        [TestCase(101.25d)]
        [TestCase(901.5d)]
        [TestCase(1d)]
        public void IsEven_AllowsNonInteger_DecimalIgnored_OddDouble_ReturnsNotEven(double doubleValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true,
                IgnoreDecimalDigits = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.That(sut.IsEven(doubleValue, algorithmType), Is.False);
                Assert.That(sut.IsOddOrEven(doubleValue, algorithmType));
                Assert.That(sut.IsOdd(doubleValue, algorithmType));
            }
        }
    }
}