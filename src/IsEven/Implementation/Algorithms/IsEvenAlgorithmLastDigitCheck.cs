using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;
using IsEven.Implementation.NumberValueProvider;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmLastDigitCheck : IsEvenAlgorithm
    {
        public IsEvenAlgorithmLastDigitCheck() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmLastDigitCheckCalculator(
                new IsEvenAlgorithmNumberValueProvider()))
        {

        }
    }
}