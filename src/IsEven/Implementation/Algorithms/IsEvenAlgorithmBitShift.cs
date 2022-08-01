using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Service;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmBitShift : IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number)
        {
            return number >> 1 << 1 == number
                ? new IsEvenAlgorithmResponseEven()
                : new IsEvenAlgorithmResponseNotEven();
        }
    }
}