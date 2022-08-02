using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Algorithms.Response
{
    internal class IsEvenAlgorithmResponseHandler : IIsEvenAlgorithmResponseHandler
    {
        public IIsEvenAlgorithmResponse GetResponse(bool isEven)
        {
            return isEven
                ? new IsEvenAlgorithmResponseEven()
                : new IsEvenAlgorithmResponseNotEven();
        }
    }
}