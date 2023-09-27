using System.Numerics;
using IsEven.Implementation.Abstractions;

namespace IsEven.Implementation.Request
{
    internal class IsEvenRequestValidatorRules : IIsEvenRequestValidatorRules
    {
        private readonly bool _allowNonIntegers;

        public IsEvenRequestValidatorRules(bool allowNonIntegers)
        {
            _allowNonIntegers = allowNonIntegers;
        }

        public bool IsValid<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return _allowNonIntegers || T.IsInteger(number);
        }
    }
}