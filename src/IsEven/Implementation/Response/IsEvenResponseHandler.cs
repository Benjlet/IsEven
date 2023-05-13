using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Response
{
    internal class IsEvenResponseHandler : IIsEvenResponseHandler
    {
        public bool GetResult(IIsEvenAlgorithmResponse response) => response?.IsEven ?? false;
    }
}