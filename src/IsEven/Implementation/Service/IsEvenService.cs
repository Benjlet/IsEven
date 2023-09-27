using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Service;
using System.Numerics;

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

        public bool IsEven<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            IIsEvenCalculator calculator = _requestHandler.Handle(algorithmType);

            IIsEvenServiceResponse isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsEven(number);
            });

            return isEvenServiceResponse.GetResult();
        }

        public bool IsOdd<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            IIsEvenCalculator calculator = _requestHandler.Handle(algorithmType);

            IIsEvenServiceResponse isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsOdd(number);
            });

            return isEvenServiceResponse.GetResult();
        }

        public bool IsOddOrEven<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>
{
            IIsEvenCalculator calculator = _requestHandler.Handle();

            IIsEvenServiceResponse isEvenServiceResponse = _responseProvider.Handle(() =>
            {
                return calculator.IsOddOrEven(number);
            });

            return isEvenServiceResponse.GetResult();
        }
    }
}