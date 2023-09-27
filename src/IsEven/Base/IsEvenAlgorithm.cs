using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Response;
using System.Numerics;

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

        public IIsEvenAlgorithmResponse Calculate<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return _isEvenAlgorithmResponseHandler.GetResponse(_isEvenAlgorithmCalculator.IsEven(number));
        }
    }
}