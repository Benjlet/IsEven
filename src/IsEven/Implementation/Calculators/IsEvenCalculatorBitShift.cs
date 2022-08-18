using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorBitShift : IsEvenCalculatorBase
    {
        public IsEvenCalculatorBitShift() : base(
            new IsEvenAlgorithmBitShift(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}