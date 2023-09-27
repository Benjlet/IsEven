using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmModulus : IsEvenAlgorithm
    {
        public IsEvenAlgorithmModulus() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmModulusCalculator())
        {

        }
    }
}