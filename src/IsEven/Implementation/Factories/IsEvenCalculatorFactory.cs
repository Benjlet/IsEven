using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Calculators;

namespace IsEven.Implementation.Factories
{
    internal static class IsEvenCalculatorFactory
    {
        internal static IIsEvenCalculator Create(AlgorithmType algorithmType) => algorithmType switch
        {
            AlgorithmType.BitwiseAmpersand => new IsEvenCalculatorBitwiseAmpersand(),
            AlgorithmType.LastDigitCheck => new IsEvenCalculatorLastDigitCheck(),
            AlgorithmType.MathDivRem => new IsEvenCalculatorMathDivRem(),
            AlgorithmType.BitShift => new IsEvenCalculatorBitShift(),
            AlgorithmType.Modulus => new IsEvenCalculatorModulus(),
            _ => new IsEvenCalculatorModulus(),
        };
    }
}