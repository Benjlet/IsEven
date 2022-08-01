using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Service;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmBitwiseAmpersand : IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number)
        {
            return (number & 1) == 0
                ? new IsEvenAlgorithmResponseEven()
                : new IsEvenAlgorithmResponseNotEven();
        }
    }
}