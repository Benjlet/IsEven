using System.Numerics;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenService
    {
        bool IsEven<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>;
        bool IsOdd<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>;
        bool IsOddOrEven<T>(T number, AlgorithmType algorithmType) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}