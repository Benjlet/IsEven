using IsEven.Base;
using IsEven.Implementation.Algorithms;
using IsEven.Implementation.Request;
using IsEven.Implementation.Response;
using IsEven.Implementation.ZeroIsEven;

namespace IsEven
{
    /// <summary>
    /// IsEven calculator using BitwiseAmpersand.
    /// </summary>
    public class IsEvenCalculatorBitwiseAmpersand : IsEvenCalculator
    {
        /// <summary>
        /// Initialises a new 'IsEven' calculator using an abstracted BitwiseAmpersand algorithm.
        /// </summary>
        public IsEvenCalculatorBitwiseAmpersand() : base(
            new IsEvenAlgorithmBitwiseAmpersand(),
            new IsEvenRequestValidator(),
            new IsEvenResponseHandler(),
            new IsEvenZeroIsEvenYes())
        {

        }
    }
}