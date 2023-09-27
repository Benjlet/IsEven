using IsEven.Implementation.Abstractions;
using System.Numerics;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmDotNetCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return T.IsEvenInteger(number);
        }
    }
}