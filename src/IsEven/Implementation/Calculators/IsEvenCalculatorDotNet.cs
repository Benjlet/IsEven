using IsEven.Abstractions;
using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorDotNet : IsEvenCalculatorBase
    {
        public IsEvenCalculatorDotNet(IIsEvenClientSettings settings) : base(
            new IsEvenAlgorithmDotNet(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            settings)
        {

        }
    }
}