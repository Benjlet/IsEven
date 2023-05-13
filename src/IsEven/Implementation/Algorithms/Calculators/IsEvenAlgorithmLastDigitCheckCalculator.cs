using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmLastDigitCheckCalculator : IIsEvenAlgorithmCalculator
    {
        private readonly IIsEvenAlgorithmNumberValueProvider _isEvenAlgorithmNumberValueProvider;

        internal IsEvenAlgorithmLastDigitCheckCalculator(IIsEvenAlgorithmNumberValueProvider isEvenAlgorithmNumberValueProvider)
        {
            _isEvenAlgorithmNumberValueProvider = isEvenAlgorithmNumberValueProvider;
        }

        public bool IsEven(int number)
        {
            var numberText = number.ToString();

            return
                (int)char.GetNumericValue(numberText[^_isEvenAlgorithmNumberValueProvider.One]) == _isEvenAlgorithmNumberValueProvider.Zero ||
                (int)char.GetNumericValue(numberText[^_isEvenAlgorithmNumberValueProvider.One]) == _isEvenAlgorithmNumberValueProvider.Two ||
                (int)char.GetNumericValue(numberText[^_isEvenAlgorithmNumberValueProvider.One]) == _isEvenAlgorithmNumberValueProvider.Four ||
                (int)char.GetNumericValue(numberText[^_isEvenAlgorithmNumberValueProvider.One]) == _isEvenAlgorithmNumberValueProvider.Six ||
                (int)char.GetNumericValue(numberText[^_isEvenAlgorithmNumberValueProvider.One]) == _isEvenAlgorithmNumberValueProvider.Eight;
        }
    }
}