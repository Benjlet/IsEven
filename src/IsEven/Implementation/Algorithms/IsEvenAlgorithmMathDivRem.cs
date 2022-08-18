using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;
using IsEven.Implementation.NumberValueProvider;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmMathDivRem : IsEvenAlgorithm
    {
        public IsEvenAlgorithmMathDivRem() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmMathDivRemCalculator(
                new IsEvenAlgorithmNumberValueProvider()))
        {

        }
    }
}