using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmBitwiseAmpersand : IsEvenAlgorithm
    {
        public IsEvenAlgorithmBitwiseAmpersand() : base(
            new IsEvenAlgorithmResponseHandler(), 
            new IsEvenAlgorithmBitwiseAmpersandCalculator())
        {
        }
    }
}