using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Response
{
    internal class IsEvenResponseHandler : IIsEvenResponseHandler
    {
        public bool GetResult(IIsEvenAlgorithmResponse response)
        {
            return response?.IsEven ?? false;
        }
    }
}