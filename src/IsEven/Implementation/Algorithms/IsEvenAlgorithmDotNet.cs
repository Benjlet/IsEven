using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmDotNet : IsEvenAlgorithm
    {
        public IsEvenAlgorithmDotNet() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmDotNetCalculator())
        {

        }
    }
}