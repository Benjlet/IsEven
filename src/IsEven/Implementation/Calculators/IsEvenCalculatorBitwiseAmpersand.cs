using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven.Implementation.Calculators
{
    internal class IsEvenCalculatorBitwiseAmpersand : IsEvenCalculatorBase
    {
        public IsEvenCalculatorBitwiseAmpersand() : base(
            new IsEvenAlgorithmBitwiseAmpersand(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}