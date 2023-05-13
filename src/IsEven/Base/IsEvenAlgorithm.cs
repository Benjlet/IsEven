using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Base
{
    internal abstract class IsEvenAlgorithm : IIsEvenAlgorithm
    {
        private readonly IIsEvenAlgorithmCalculator _isEvenAlgorithmCalculator;
        private readonly IIsEvenAlgorithmResponseHandler _isEvenAlgorithmResponseHandler;

        public IsEvenAlgorithm(
            IIsEvenAlgorithmResponseHandler isEvenAlgorithmResponseHandler,
            IIsEvenAlgorithmCalculator isEvenAlgorithmCalculator)
        {
            _isEvenAlgorithmResponseHandler = isEvenAlgorithmResponseHandler;
            _isEvenAlgorithmCalculator = isEvenAlgorithmCalculator;
        }

        public IIsEvenAlgorithmResponse Calculate(int number)
        {
            return _isEvenAlgorithmResponseHandler.GetResponse(_isEvenAlgorithmCalculator.IsEven(number));
        }
    }
}