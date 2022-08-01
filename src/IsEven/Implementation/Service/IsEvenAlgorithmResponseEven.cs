using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Service
{
    internal class IsEvenAlgorithmResponseEven : IIsEvenAlgorithmResponse
    {
        public bool IsEven => true;
    }
}