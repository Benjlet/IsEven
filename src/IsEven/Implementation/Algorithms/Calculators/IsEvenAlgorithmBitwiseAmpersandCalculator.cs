using IsEven.Abstractions;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmBitwiseAmpersandCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven(int number) => (number & 1) == 0;
    }
}