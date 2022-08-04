using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven
{
    /// <summary>
    /// IsEven calculator using BitShift.
    /// </summary>
    public class IsEvenCalculatorBitShift : IsEvenCalculator
    {
        /// <summary>
        /// Initialises a new 'IsEven' calculator using an abstracted BitShift algorithm.
        /// </summary>
        public IsEvenCalculatorBitShift() : base(
            new IsEvenAlgorithmBitShift(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}