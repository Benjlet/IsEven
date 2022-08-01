using IsEven.Abstractions.Response;

namespace IsEven.Implementation.Response
{
    internal class IsEvenValidationResponseInvalid : IIsEvenValidationResponse
    {
        public bool IsValid => false;
    }
}