using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Response;

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