using IsEven.Abstractions;
using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Request.Service;
using IsEven.Implementation.Response.Service;
using IsEven.Implementation.Service;

namespace IsEven
{
    /// <summary>
    /// Service client for determining if a number is even, odd, or neither even nor odd.
    /// </summary>
    public class IsEvenClient : IIsEvenService, IIsEvenClient
    {
        private readonly IIsEvenService _service;
        private readonly AlgorithmType _defaultAlgorithm;

        /// <summary>
        /// Initialises a new client for calculating if an integer is even, odd, or neither even nor odd, using the Modulus algorithm as default.
        /// </summary>
        /// <param name="defaultAlgorithm">The default algorithm to use, if not specified, defaulting to Modulus.</param>
        public IsEvenClient(AlgorithmType defaultAlgorithm = AlgorithmType.Modulus)
        {
            _service = new IsEvenService(
                new IsEvenServiceRequestHandler(),
                new IsEvenServiceResponseHandler());

            _defaultAlgorithm = defaultAlgorithm;
        }

        internal IsEvenClient(IIsEvenService isEvenService, AlgorithmType defaultAlgorithm = AlgorithmType.Modulus)
        {
            _service = isEvenService;
            _defaultAlgorithm = defaultAlgorithm;
        }

        /// <summary>
        /// Calculates if the specified number is even.
        /// </summary>
        /// <param name="number">The number for even-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true; not even (or odd, as one could infer) is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number)
        {
            return _service.IsEven(number, _defaultAlgorithm);
        }

        /// <summary>
        /// Calculates if the specified number is even, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for even-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for even-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true; not even (or odd, as one could infer) is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number, AlgorithmType algorithmType)
        {
            return _service.IsEven(number, algorithmType);
        }

        /// <summary>
        /// Calculates if the specified number is odd.
        /// </summary>
        /// <param name="number">The number for odd-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true; not odd (or even, as one could infer) is represented by false.
        /// Take, for example, the number 1, which is returned as true; 2, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number)
        {
            return _service.IsOdd(number, _defaultAlgorithm);
        }

        /// <summary>
        /// Calculates if the specified number is odd, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for odd-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for odd-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true; not odd (or even, as one could infer) is represented by false.
        /// Take, for example, the number 1, which is returned as true; 2, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number, AlgorithmType algorithmType)
        {
            return _service.IsOdd(number, algorithmType);
        }

        /// <summary>
        /// Calculates if the specified number is either odd or even.
        /// </summary>
        /// <param name="number">The number for evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating whether the integer is either odd or even.
        /// </returns>
        public bool IsOddOrEven(int number)
        {
            return _service.IsOddOrEven(number);
        }
    }
}