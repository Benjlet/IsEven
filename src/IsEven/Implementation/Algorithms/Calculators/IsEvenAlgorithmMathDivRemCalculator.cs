using IsEven.Abstractions;
using IsEven.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmMathDivRemCalculator : IIsEvenAlgorithmCalculator
    {
        private readonly IIsEvenAlgorithmNumberValueProvider _isEvenAlgorithmNumberValueProvider;

        internal IsEvenAlgorithmMathDivRemCalculator(IIsEvenAlgorithmNumberValueProvider isEvenAlgorithmNumberValueProvider)
        {
            _isEvenAlgorithmNumberValueProvider = isEvenAlgorithmNumberValueProvider;
        }

        public bool IsEven(int number)
        {
            Math.DivRem((long)number, _isEvenAlgorithmNumberValueProvider.Two, out var result);
            return result == _isEvenAlgorithmNumberValueProvider.Zero;
        }
    }
}