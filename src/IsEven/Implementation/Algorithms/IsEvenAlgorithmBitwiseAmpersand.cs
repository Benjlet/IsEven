using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;
using IsEven.Implementation.NumberValueProvider;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmBitwiseAmpersand : IsEvenAlgorithm
    {
        public IsEvenAlgorithmBitwiseAmpersand() : base(
            new IsEvenAlgorithmResponseHandler(), 
            new IsEvenAlgorithmBitwiseAmpersandCalculator(
                new IsEvenAlgorithmNumberValueProvider()))
        {

        }
    }
}