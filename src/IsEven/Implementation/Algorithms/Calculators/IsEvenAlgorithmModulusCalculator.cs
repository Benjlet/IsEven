using IsEven.Abstractions;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmModulusCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven(int number) => number % 2 == 0;
    }
}