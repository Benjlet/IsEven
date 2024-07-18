using IsEven.Abstractions;
using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorModulus : IsEvenCalculatorBase
    {
        public IsEvenCalculatorModulus(IIsEvenClientSettings settings) : base(
            new IsEvenAlgorithmModulus(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            settings)
        {

        }
    }
}