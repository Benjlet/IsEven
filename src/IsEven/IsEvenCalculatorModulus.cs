using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;

namespace IsEven
{
    public class IsEvenCalculatorModulus : IsEvenCalculator
    {
        public IsEvenCalculatorModulus() : base(
            new IsEvenAlgorithmModulus(),
            new IsEvenRequestValidator(), 
            new IsEvenResponseHandler())
        {

        }
    }
}