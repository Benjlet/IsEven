using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Response
{
    internal class IsEvenValidationResponseSuccess : IIsEvenValidationResponse
    {
        public bool IsValid => true;
    }
}