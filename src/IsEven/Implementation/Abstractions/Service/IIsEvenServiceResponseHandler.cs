namespace IsEven.Implementation.Abstractions.Service
{
    internal interface IIsEvenServiceResponseHandler
    {
        public IIsEvenServiceResponse Handle(Func<bool> calculator);
    }
}