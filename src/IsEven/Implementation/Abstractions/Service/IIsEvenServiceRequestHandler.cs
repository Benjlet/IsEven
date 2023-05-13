namespace IsEven.Implementation.Abstractions.Service
{
    internal interface IIsEvenServiceRequestHandler
    {
        public IIsEvenCalculator Handle(AlgorithmType algorithm = AlgorithmType.Modulus);
    }
}