using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Service;
using IsEven.Implementation.Factories;

namespace IsEven.Implementation.Request.Service
{
    internal class IsEvenServiceRequestHandler : IIsEvenServiceRequestHandler
    {
        public IIsEvenCalculator Handle(AlgorithmType algorithm = AlgorithmType.Modulus)
        {
            return IsEvenCalculatorFactory.Create(algorithm);
        }
    }
}