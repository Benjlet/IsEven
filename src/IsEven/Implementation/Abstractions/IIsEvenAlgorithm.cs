using IsEven.Implementation.Abstractions.Response;
using System.Numerics;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}