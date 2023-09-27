using IsEven.Base;
using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorLastDigitCheck : IsEvenCalculatorBase
    {
        public IsEvenCalculatorLastDigitCheck(IIsEvenClientSettings settings) : base(
            new IsEvenAlgorithmLastDigitCheck(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            settings)
        {

        }
    }
}