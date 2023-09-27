using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Calculators;

namespace IsEven.Implementation.Factories
{
    internal static class IsEvenCalculatorFactory
    {
        internal static IIsEvenCalculator Create(AlgorithmType algorithmType, IIsEvenClientSettings settings) => algorithmType switch
        {
            AlgorithmType.Modulus => new IsEvenCalculatorModulus(settings),
            AlgorithmType.LastDigitCheck => new IsEvenCalculatorLastDigitCheck(settings),
            AlgorithmType.DotNet => new IsEvenCalculatorDotNet(settings),
            _ => new IsEvenCalculatorModulus(settings),
        };
    }
}