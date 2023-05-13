using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number);
    }
}