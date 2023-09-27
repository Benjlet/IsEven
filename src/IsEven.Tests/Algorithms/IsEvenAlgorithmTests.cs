using IsEven.Base;
using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Response;
using IsEven.Implementation.Algorithms.Response;
using Moq;
using NUnit.Framework;

namespace IsEven.Tests.Calculators
{
    public class IsEvenAlgorithmTests
    {
        private IsEvenAlgorithm _algorithm;
        private Mock<IIsEvenAlgorithmResponseHandler> _mockResponseHandler;
        private Mock<IIsEvenAlgorithmCalculator> _mockCalculator;

        [SetUp]
        public void Setup()
        {
            _mockResponseHandler = new Mock<IIsEvenAlgorithmResponseHandler>();
            _mockCalculator = new Mock<IIsEvenAlgorithmCalculator>();

            _mockResponseHandler.Setup(x => x.GetResponse(true)).Returns(new IsEvenAlgorithmResponseEven());
            _mockResponseHandler.Setup(x => x.GetResponse(false)).Returns(new IsEvenAlgorithmResponseNotEven());

            _mockCalculator.Setup(x => x.IsEven(It.IsAny<int>())).Returns(true);

            _algorithm = new TestAlgorithm(_mockResponseHandler.Object, _mockCalculator.Object);
        }

        [Test]
        public void Calculate_EvenResult_ReturnsEven()
        {
            IIsEvenAlgorithmResponse result = _algorithm.Calculate(0);

            Assert.That(result.IsEven);
        }

        internal class TestAlgorithm : IsEvenAlgorithm
        {
            public TestAlgorithm(IIsEvenAlgorithmResponseHandler isEvenAlgorithmResponseHandler, IIsEvenAlgorithmCalculator isEvenAlgorithmCalculator) : base(isEvenAlgorithmResponseHandler, isEvenAlgorithmCalculator)
            {
            }
        }
    }
}