using IsEven.Implementation.Abstractions.Service;

namespace IsEven.Implementation.Response.Service
{
    internal class IsEvenServiceResponseHandler : IIsEvenServiceResponseHandler
    {
        public IIsEvenServiceResponse Handle(Func<bool> calculator)
        {
            bool isSuccess = calculator?.Invoke() ?? false;
            return isSuccess ? new IsEvenServiceResponseTrue() : new IsEvenServiceResponseFalse();
        }
    }
}