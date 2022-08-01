using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.Service;

namespace IsEven
{
    public class IsEvenCalculatorBitShift : IsEvenCalculator
    {
        public IsEvenCalculatorBitShift() : base(
            new IsEvenAlgorithmBitShift(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler())
        {

        }
    }
}