using IsEven.Implementation.Abstractions;
using Moq;
using NUnit.Framework;

namespace IsEven.Tests.Calculators
{
    public class IsEvenClientTests
    {
        private IsEvenClient _client;
        private Mock<IIsEvenService> _mockIsEvenService;

        [SetUp]
        public void Setup()
        {
            _mockIsEvenService = new Mock<IIsEvenService>();

            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>())).Returns(true);
            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>(), It.IsAny<AlgorithmType>())).Returns(true);

            _client = new IsEvenClient(_mockIsEvenService.Object);
        }

        [Test]
        public void IsEven_DependenciesReturnsTrue_ReturnsTrue()
        {
            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>())).Returns(true);
            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>(), It.IsAny<AlgorithmType>())).Returns(true);

            var result = _client.IsEven(3);
            var resultWithoutAlgorithm = _client.IsEven(3, AlgorithmType.MathDivRem);

            Assert.Multiple(() =>
            {
                Assert.That(result);
                Assert.That(resultWithoutAlgorithm);
            });
        }

        [Test]
        public void IsEven_DependenciesReturnsFalse_ReturnsFalse()
        {
            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>())).Returns(false);
            _mockIsEvenService.Setup(x => x.IsEven(It.IsAny<int>(), It.IsAny<AlgorithmType>())).Returns(false);

            var result = _client.IsEven(3);
            var resultWithoutAlgorithm = _client.IsEven(3, AlgorithmType.MathDivRem);

            Assert.Multiple(() =>
            {
                Assert.That(!result);
                Assert.That(!resultWithoutAlgorithm);
            });
        }

        [Test]
        public void IsOdd_DependenciesReturnsTrue_ReturnsTrue()
        {
            _mockIsEvenService.Setup(x => x.IsOdd(It.IsAny<int>())).Returns(true);
            _mockIsEvenService.Setup(x => x.IsOdd(It.IsAny<int>(), It.IsAny<AlgorithmType>())).Returns(true);

            var result = _client.IsOdd(3);
            var resultWithoutAlgorithm = _client.IsOdd(3, AlgorithmType.MathDivRem);

            Assert.Multiple(() =>
            {
                Assert.That(result);
                Assert.That(resultWithoutAlgorithm);
            });
        }

        [Test]
        public void IsOdd_DependenciesReturnsFalse_ReturnsFalse()
        {
            _mockIsEvenService.Setup(x => x.IsOdd(It.IsAny<int>())).Returns(false);
            _mockIsEvenService.Setup(x => x.IsOdd(It.IsAny<int>(), It.IsAny<AlgorithmType>())).Returns(false);

            var result = _client.IsOdd(3);
            var resultWithoutAlgorithm = _client.IsOdd(3, AlgorithmType.MathDivRem);

            Assert.Multiple(() =>
            {
                Assert.That(!result);
                Assert.That(!resultWithoutAlgorithm);
            });
        }

        [Test]
        public void IsOddOrEven_DependenciesReturnsTrue_ReturnsTrue()
        {
            _mockIsEvenService.Setup(x => x.IsOddOrEven(It.IsAny<int>())).Returns(true);

            var result = _client.IsOddOrEven(3);

            Assert.That(result);
        }

        [Test]
        public void IsOddOrEven_DependenciesReturnsFalse_ReturnsFalse()
        {
            _mockIsEvenService.Setup(x => x.IsOddOrEven(It.IsAny<int>())).Returns(false);

            var result = _client.IsOddOrEven(3);

            Assert.That(!result);
        }
    }
}