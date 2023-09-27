using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Service;
using IsEven.Implementation.Factories;

namespace IsEven.Implementation.Request.Service
{
    internal class IsEvenServiceRequestHandler : IIsEvenServiceRequestHandler
    {
        private readonly IIsEvenClientSettings _settings;

        public IsEvenServiceRequestHandler(IIsEvenClientSettings settings)
        {
            _settings = settings;
        }

        public IIsEvenCalculator Handle(AlgorithmType algorithm = AlgorithmType.Modulus)
        {
            return IsEvenCalculatorFactory.Create(algorithm, _settings);
        }
    }
}