using IsEven.Implementation.Abstractions.Service;

namespace IsEven.Implementation.Response.Service
{
    internal class IsEvenServiceResponseFalse : IIsEvenServiceResponse
    {
        public bool GetResult()
        {
            return false;
        }
    }
}