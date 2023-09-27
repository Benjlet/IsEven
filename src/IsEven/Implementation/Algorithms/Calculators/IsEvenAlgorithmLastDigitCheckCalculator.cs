using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Extensions;
using System.Numerics;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmLastDigitCheckCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            string numberText = number.ToString().LastCharacter();

            return
                numberText[^1] == '0' ||
                numberText[^1] == '2' ||
                numberText[^1] == '4' ||
                numberText[^1] == '6' ||
                numberText[^1] == '8';
        }
    }
}