using IsEven.Implementation.Abstractions.Service;

namespace IsEven.Implementation.Response.Service
{
    internal class IsEvenServiceResponseTrue : IIsEvenServiceResponse
    {
        public bool GetResult()
        {
            return true;
        }
    }
}