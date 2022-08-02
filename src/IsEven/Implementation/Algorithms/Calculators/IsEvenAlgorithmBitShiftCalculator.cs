using IsEven.Abstractions;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmBitShiftCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven(int number) => number >> 1 << 1 == number;
    }
}