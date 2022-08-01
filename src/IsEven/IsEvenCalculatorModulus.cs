using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.Service;

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