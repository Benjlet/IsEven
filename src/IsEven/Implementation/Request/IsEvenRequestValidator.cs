using IsEven.Implementation.Abstractions.Request;
using IsEven.Implementation.Abstractions.Response;
using IsEven.Implementation.Response.Validation;

namespace IsEven.Implementation.Request
{
    internal class IsEvenRequestValidator : IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number)
        {
            if (number > int.MaxValue || number < int.MinValue)
                return new IsEvenValidationResponseInvalid();

            return new IsEvenValidationResponseSuccess();
        }
    }
}