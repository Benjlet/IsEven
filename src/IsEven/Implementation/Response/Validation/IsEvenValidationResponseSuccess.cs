using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Response.Validation
{
    internal class IsEvenValidationResponseSuccess : IIsEvenValidationResponse
    {
        public bool IsValid => true;
    }
}