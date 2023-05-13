using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Service;

namespace IsEven.Implementation.Service
{
    internal class IsEvenService : IIsEvenService
    {
        private readonly IIsEvenServiceRequestHandler _requestHandler;
        private readonly IIsEvenServiceResponseHandler _responseProvider;

        public IsEvenService(
            IIsEvenServiceRequestHandler requestHandler,
            IIsEvenServiceResponseHandler responseProvider)
        {
            _requestHandler = requestHandler;
            _responseProvider = responseProvider;
        }

        public bool IsEven(int number, AlgorithmType algorithmType)
        {
            var calculator = _requestHandler.Handle(algorithmType);

            var isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsEven(number);
            });

            return isEvenServiceResponse.GetResult();
        }

        public bool IsOdd(int number, AlgorithmType algorithmType)
        {
            var calculator = _requestHandler.Handle(algorithmType);

            var isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsOdd(number);
            });

            return isEvenServiceResponse.GetResult();
        }

        public bool IsOddOrEven(int number)
        {
            var calculator = _requestHandler.Handle();

            var isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsOddOrEven(number);
            });

            return isEvenServiceResponse.GetResult();
        }

        public bool IsOdd(int number)
        {
            return IsOdd(number, AlgorithmType.Modulus);
        }

        public bool IsEven(int number)
        {
            return IsEven(number, AlgorithmType.Modulus);
        }
    }
}