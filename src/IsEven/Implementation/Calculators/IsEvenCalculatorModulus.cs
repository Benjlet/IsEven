using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorModulus : IsEvenCalculatorBase
    {
        public IsEvenCalculatorModulus() : base(
            new IsEvenAlgorithmModulus(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}