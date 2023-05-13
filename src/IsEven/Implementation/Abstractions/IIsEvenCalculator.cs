namespace IsEven.Implementation.Abstractions
{
    internal interface IIsEvenCalculator
    {
        public bool IsEven(int number);
        public bool IsOdd(int number);
        public bool IsOddOrEven(int number);
    }
}