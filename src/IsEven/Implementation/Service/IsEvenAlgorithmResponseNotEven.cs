using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Service
{
    internal class IsEvenAlgorithmResponseNotEven : IIsEvenAlgorithmResponse
    {
        public bool IsEven => false;
    }
}