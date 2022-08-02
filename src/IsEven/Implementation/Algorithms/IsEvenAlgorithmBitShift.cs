using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmBitShift : IsEvenAlgorithm
    {
        public IsEvenAlgorithmBitShift() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmBitShiftCalculator())
        {
        }
    }
}