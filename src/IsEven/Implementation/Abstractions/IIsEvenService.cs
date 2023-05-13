namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenService
    {
        bool IsEven(int number);
        bool IsEven(int number, AlgorithmType algorithmType);
        bool IsOdd(int number);
        bool IsOdd(int number, AlgorithmType algorithmType);
        bool IsOddOrEven(int number);
    }
}