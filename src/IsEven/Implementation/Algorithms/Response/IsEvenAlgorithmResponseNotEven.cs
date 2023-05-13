using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Algorithms.Response
{
    internal class IsEvenAlgorithmResponseNotEven : IIsEvenAlgorithmResponse
    {
        public bool IsEven => false;
    }
}