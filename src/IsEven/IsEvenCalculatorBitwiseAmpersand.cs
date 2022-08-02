using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;

namespace IsEven
{
    public class IsEvenCalculatorBitwiseAmpersand : IsEvenCalculator
    {
        public IsEvenCalculatorBitwiseAmpersand() : base(
            new IsEvenAlgorithmBitwiseAmpersand(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler())
        {

        }
    }
}