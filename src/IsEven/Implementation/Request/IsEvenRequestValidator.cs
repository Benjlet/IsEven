using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Request;
using IsEven.Implementation.Abstractions.Response;
using IsEven.Implementation.Response.Validation;
using System.Numerics;

namespace IsEven.Implementation.Request
{
    internal class IsEvenRequestValidator : IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate<T, V>(T number, V validator) where T : INumber<T>, IModulusOperators<T, T, T> where V : IIsEvenRequestValidatorRules
        {
            return validator.IsValid(number) ? new IsEvenValidationResponseSuccess() : new IsEvenValidationResponseInvalid();
        }
    }
}