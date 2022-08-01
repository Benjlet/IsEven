using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    public interface IIsEvenAlgorithm
    {
        public IIsEvenAlgorithmResponse Calculate(int number);
    }
}