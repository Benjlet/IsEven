using IsEven.Abstractions;
using IsEven.Abstractions.Response;
using IsEven.Implementation.Response;

namespace IsEven.Implementation.Request
{
    internal class IsEvenRequestValidator : IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number) => new IsEvenValidationResponseSuccess();
    }
}