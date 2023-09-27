using System.Numerics;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenRequestValidatorRules
    {
        bool IsValid<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}