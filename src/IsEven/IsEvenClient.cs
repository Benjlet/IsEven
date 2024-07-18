using IsEven.Abstractions;
using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Request.Service;
using IsEven.Implementation.Response.Service;
using IsEven.Implementation.Service;
using System.Numerics;

namespace IsEven
{
    /// <summary>
    /// Service client for determining if a number is even, odd, or neither even nor odd.
    /// </summary>
    public class IsEvenClient : IIsEvenClient
    {
        private readonly IIsEvenService _service;

        /// <summary>
        /// Initialises a new client for calculating if a number is even, odd, or neither even nor odd, using the Modulus algorithm as default.
        /// </summary>
        public IsEvenClient()
        {
            _service = new IsEvenService(
                new IsEvenServiceRequestHandler(new IsEvenClientDefaultSettings()),
                new IsEvenServiceResponseHandler());
        }

        /// <summary>
        /// Initialises a new client for calculating if a number is even, odd, or neither even nor odd, using the Modulus algorithm as default.
        /// </summary>
        public IsEvenClient(IIsEvenClientSettings settings)
        {
            _service = new IsEvenService(
                new IsEvenServiceRequestHandler(settings),
                new IsEvenServiceResponseHandler());
        }

        internal IsEvenClient(IIsEvenService isEvenService)
        {
            _service = isEvenService;
        }

        /// <inheritdoc/>
        public bool IsEven<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return _service.IsEven(number, algorithmType);
        }

        /// <inheritdoc/>
        public bool IsOdd<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return _service.IsOdd(number, algorithmType);
        }

        /// <inheritdoc/>
        public bool IsOddOrEven<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return _service.IsOddOrEven(number, algorithmType);
        }
    }
}