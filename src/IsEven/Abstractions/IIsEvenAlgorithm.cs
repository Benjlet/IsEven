using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    internal interface IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number);
    }
}