using IsEven.Abstractions;
using IsEven.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmModulusCalculator : IIsEvenAlgorithmCalculator
    {
        private readonly IIsEvenAlgorithmNumberValueProvider _isEvenAlgorithmNumberValueProvider;

        internal IsEvenAlgorithmModulusCalculator(IIsEvenAlgorithmNumberValueProvider isEvenAlgorithmNumberValueProvider)
        {
            _isEvenAlgorithmNumberValueProvider = isEvenAlgorithmNumberValueProvider;
        }

        public bool IsEven(int number)
        {
            return number % _isEvenAlgorithmNumberValueProvider.Two == _isEvenAlgorithmNumberValueProvider.Zero;
        }
    }
}