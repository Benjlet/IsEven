using IsEven.Tests.Models;
using NUnit.Framework;
using System.Numerics;

namespace IsEven.Tests.Calculators
{
    public class IntegralTests
    {
        [Test]
        [TestCase((byte)0)]
        [TestCase((byte)4)]
        [TestCase((byte)254)]
        [TestCase((sbyte)-20)]
        [TestCase((sbyte)0)]
        [TestCase((sbyte)4)]
        [TestCase((sbyte)120)]
        [TestCase((short)-32000)]
        [TestCase((short)0)]
        [TestCase((short)24)]
        [TestCase((short)32000)]
        [TestCase((ushort)0)]
        [TestCase((ushort)24)]
        [TestCase((ushort)32000)]
        [TestCase((long)0)]
        [TestCase((long)24)]
        [TestCase((long)32000)]
        [TestCase((uint)0)]
        [TestCase((uint)24)]
        [TestCase((uint)32000)]
        [TestCase(0)]
        [TestCase(24)]
        [TestCase(32000)]
        public void Default_BehavesSameAsDotNet<T>(T number) where T : INumber<T>
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
        [TestCase((byte)0)]
        [TestCase((byte)4)]
        [TestCase((byte)254)]
        public void IsEven_AllowsNonInteger_EvenByte_ReturnsEven(byte byteValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(byteValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(byteValue, algorithmType));
                    Assert.That(sut.IsOdd(byteValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((byte)1)]
        [TestCase((byte)9)]
        [TestCase((byte)111)]
        public void IsEven_OddByte_ReturnsOdd_NotEven(byte byteValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.That(sut.IsEven(byteValue, algorithmType), Is.False);
                Assert.That(sut.IsOddOrEven(byteValue, algorithmType));
                Assert.That(sut.IsOdd(byteValue, algorithmType));
            }
        }

        [Test]
        [TestCase((sbyte)-20)]
        [TestCase((sbyte)0)]
        [TestCase((sbyte)4)]
        [TestCase((sbyte)120)]
        public void IsEven_EvenSignedByte_ReturnsEven_NotOdd(sbyte byteValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(byteValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(byteValue, algorithmType));
                    Assert.That(sut.IsOdd(byteValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((sbyte)-91)]
        [TestCase((sbyte)9)]
        [TestCase((sbyte)111)]
        public void IsEven_OddSignedByte_ReturnsOdd_NotEven(sbyte byteValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(byteValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(byteValue, algorithmType));
                    Assert.That(sut.IsOdd(byteValue, algorithmType));
                });
            }
        }

        [Test]
        [TestCase((short)-32000)]
        [TestCase((short)0)]
        [TestCase((short)24)]
        [TestCase((short)32000)]
        public void IsEven_EvenSignedShort_ReturnsEven_NotOdd(short shortValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(shortValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(shortValue, algorithmType));
                    Assert.That(sut.IsOdd(shortValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((short)-26789)]
        [TestCase((short)9)]
        [TestCase((short)12345)]
        public void IsEven_OddSignedShort_ReturnsOdd_NotEven(short shortValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(shortValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(shortValue, algorithmType));
                    Assert.That(sut.IsOdd(shortValue, algorithmType));
                });
            }
        }
        
        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)24)]
        [TestCase((ushort)32000)]
        public void IsEven_EvenUnsignedShort_ReturnsEven_NotOdd(ushort shortValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(shortValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(shortValue, algorithmType));
                    Assert.That(sut.IsOdd(shortValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase((ushort)9)]
        [TestCase((ushort)65533)]
        public void IsEven_OddUnsignedShort_ReturnsOdd_NotEven(ushort shortValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(shortValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(shortValue, algorithmType));
                    Assert.That(sut.IsOdd(shortValue, algorithmType));
                });
            }
        }

        [Test]
        [TestCase(0)]
        [TestCase(24)]
        [TestCase(32000)]
        public void IsEven_EvenInteger_ReturnsEven_NotOdd(int intValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(intValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(intValue, algorithmType));
                    Assert.That(sut.IsOdd(intValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase(1)]
        [TestCase(9)]
        [TestCase(65533)]
        public void IsEven_OddInteger_ReturnsOdd_NotEven(int intValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(intValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(intValue, algorithmType));
                    Assert.That(sut.IsOdd(intValue, algorithmType));
                });
            }
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)24)]
        [TestCase((uint)32000)]
        public void IsEven_EvenUnsignedInteger_ReturnsEven_NotOdd(uint intValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(intValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(intValue, algorithmType));
                    Assert.That(sut.IsOdd(intValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase((uint)9)]
        [TestCase((uint)65533)]
        public void IsEven_OddUnsignedInteger_ReturnsOdd_NotEven(uint intValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(intValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(intValue, algorithmType));
                    Assert.That(sut.IsOdd(intValue, algorithmType));
                });
            }
        }

        [Test]
        [TestCase((long)0)]
        [TestCase((long)24)]
        [TestCase((long)32000)]
        public void IsEven_EvenLong_ReturnsEven_NotOdd(long longValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(longValue, algorithmType));
                    Assert.That(sut.IsOddOrEven(longValue, algorithmType));
                    Assert.That(sut.IsOdd(longValue, algorithmType), Is.False);
                });
            }
        }

        [Test]
        [TestCase((long)1)]
        [TestCase((long)9)]
        [TestCase(9223372775)]
        public void IsEven_OddLong_ReturnsOdd_NotEven(long longValue)
        {
            TestIsEvenSettings settings = new()
            {
                IntegersOnly = false,
                IsZeroEven = true
            };

            IsEvenClient sut = new(settings);

            foreach (AlgorithmType algorithmType in Enum.GetValues(typeof(AlgorithmType)))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(sut.IsEven(longValue, algorithmType), Is.False);
                    Assert.That(sut.IsOddOrEven(longValue, algorithmType));
                    Assert.That(sut.IsOdd(longValue, algorithmType));
                });
            }
        }

        [Test]
        public void BasicDefault_IsValid()
        {
            int evenValue = 4;

            IsEvenClient client = new();

            Assert.That(client.IsEven(evenValue));
            Assert.That(client.IsOdd(evenValue), Is.False);
        }
    }
}