using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Response;

namespace IsEven.Implementation.Request
{
    internal class IsEvenRequestValidator : IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number)
        {
            // Return IsEvenValidationResponseInvalid if the int is higher than the maximum value for an int or less than the lowest possible value of an int.
            if (number > int.MaxValue || number < int.MinValue)
                return new IsEvenValidationResponseInvalid();

            // Return IsEvenValidationResponseSuccess.
            return new IsEvenValidationResponseSuccess();
        }
    }
}