using System.Numerics;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenAlgorithmCalculator
    {
        bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}