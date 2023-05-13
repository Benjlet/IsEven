using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Response.Validation
{
    internal class IsEvenValidationResponseInvalid : IIsEvenValidationResponse
    {
        public bool IsValid => false;
    }
}