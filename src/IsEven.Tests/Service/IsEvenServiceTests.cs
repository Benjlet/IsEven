using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Service;
using IsEven.Implementation.Response.Service;
using IsEven.Implementation.Service;
using Moq;
using NUnit.Framework;

namespace IsEven.Tests.Calculators
{
    public class IsEvenServiceTests
    {
        private IsEvenService _service;
        private Mock<IIsEvenServiceRequestHandler> _mockRequestHandler;
        private Mock<IIsEvenServiceResponseHandler> _mockResponseHandler;
        private Mock<IIsEvenCalculator> _mockCalculator;

        [SetUp]
        public void Setup()
        {
            _mockRequestHandler = new Mock<IIsEvenServiceRequestHandler>();
            _mockResponseHandler = new Mock<IIsEvenServiceResponseHandler>();
            _mockCalculator = new Mock<IIsEvenCalculator>();

            _mockCalculator.Setup(x => x.IsEven(It.IsAny<int>())).Returns(true);
            _mockCalculator.Setup(x => x.IsOdd(It.IsAny<int>())).Returns(true);
            _mockCalculator.Setup(x => x.IsOddOrEven(It.IsAny<int>())).Returns(true);

            _mockRequestHandler.Setup(x => x.Handle(It.IsAny<AlgorithmType>())).Returns(_mockCalculator.Object);

            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerSuccess);

            _service = new IsEvenService(_mockRequestHandler.Object, _mockResponseHandler.Object);
        }

        [Test]
        public void IsEven_ResponseSuccess_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerSuccess);

            bool resultAlgorithm = _service.IsEven(2, AlgorithmType.Modulus);

            Assert.That(resultAlgorithm, Is.True);
        }

        [Test]
        public void IsEven_ResponseFailure_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerFailure);

            bool resultAlgorithm = _service.IsEven(2, AlgorithmType.Modulus);
            
            Assert.That(resultAlgorithm, Is.False);
        }

        [Test]
        public void IsOdd_ResponseSuccess_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerSuccess);

            bool resultAlgorithm = _service.IsOdd(1, AlgorithmType.Modulus);
            
            Assert.That(resultAlgorithm, Is.True);
        }

        [Test]
        public void IsOdd_ResponseFailure_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerFailure);

            bool resultAlgorithm = _service.IsOdd(1, AlgorithmType.Modulus);
            
            Assert.That(resultAlgorithm, Is.False);
        }

        [Test]
        public void IsOddOrEven_ResponseSuccess_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerSuccess);

            bool resultAlgorithm = _service.IsOddOrEven(1, AlgorithmType.Modulus);

            Assert.That(resultAlgorithm, Is.True);
        }

        [Test]
        public void IsOddOrEven_ResponseFailure_ReturnsDependencyResults()
        {
            _mockResponseHandler.Setup(x => x.Handle(It.IsAny<Func<bool>>())).Returns(ResponseHandlerFailure);

            bool resultAlgorithm = _service.IsOddOrEven(1, AlgorithmType.Modulus);

            Assert.That(resultAlgorithm, Is.False);
        }

        private IIsEvenServiceResponse ResponseHandlerSuccess() => new IsEvenServiceResponseTrue();
        private IIsEvenServiceResponse ResponseHandlerFailure() => new IsEvenServiceResponseFalse();
    }
}