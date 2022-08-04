using IsEven.Abstractions;
using IsEven.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmBitwiseAmpersandCalculator : IIsEvenAlgorithmCalculator
    {
        private readonly IIsEvenAlgorithmNumberValueProvider _isEvenAlgorithmNumberValueProvider;

        internal IsEvenAlgorithmBitwiseAmpersandCalculator(IIsEvenAlgorithmNumberValueProvider isEvenAlgorithmNumberValueProvider)
        {
            _isEvenAlgorithmNumberValueProvider = isEvenAlgorithmNumberValueProvider;
        }

        public bool IsEven(int number) => (number & _isEvenAlgorithmNumberValueProvider.One) == _isEvenAlgorithmNumberValueProvider.Zero;
    }
}