using System.Numerics;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenCalculator
    {
        bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
        bool IsOdd<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
        bool IsOddOrEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}