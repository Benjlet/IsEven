using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Service;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmModulus : IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number)
        {
            return number % 2 == 0
                ? new IsEvenAlgorithmResponseEven()
                : new IsEvenAlgorithmResponseNotEven();
        }
    }
}