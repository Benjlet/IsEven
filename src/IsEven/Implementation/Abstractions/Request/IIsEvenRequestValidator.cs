using IsEven.Implementation.Abstractions.Response;
using System.Numerics;

namespace IsEven.Implementation.Abstractions.Request
{
    internal interface IIsEvenRequestValidator
    {
        IIsEvenValidationResponse Validate<T, V>(T number, V validator)
            where T : INumber<T>, IModulusOperators<T, T, T>
            where V : IIsEvenRequestValidatorRules;
    }
}