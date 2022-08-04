using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;
using IsEven.Implementation.NumberValueProvider;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmModulus : IsEvenAlgorithm
    {
        public IsEvenAlgorithmModulus() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmModulusCalculator(
                new IsEvenAlgorithmNumberValueProvider()))
        {
        }
    }
}