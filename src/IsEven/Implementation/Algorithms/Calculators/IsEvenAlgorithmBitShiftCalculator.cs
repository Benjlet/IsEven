using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmBitShiftCalculator : IIsEvenAlgorithmCalculator
    {
        private readonly IIsEvenAlgorithmNumberValueProvider _isEvenAlgorithmNumberValueProvider;

        internal IsEvenAlgorithmBitShiftCalculator(IIsEvenAlgorithmNumberValueProvider isEvenAlgorithmNumberValueProvider)
        {
            _isEvenAlgorithmNumberValueProvider = isEvenAlgorithmNumberValueProvider;
        }

        public bool IsEven(int number)
        {
            return number >> _isEvenAlgorithmNumberValueProvider.One << _isEvenAlgorithmNumberValueProvider.One == number;
        }
    }
}