using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven
{
    /// <summary>
    /// IsEven calculator using Modulo Division.
    /// </summary>
    public class IsEvenCalculatorModulus : IsEvenCalculator
    {
        /// <summary>
        /// Initialises a new 'IsEven' calculator using an abstracted Modulo Division algorithm.
        /// </summary>
        public IsEvenCalculatorModulus() : base(
            new IsEvenAlgorithmModulus(),
            new IsEvenRequestValidator(), 
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}