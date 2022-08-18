using IsEven.Abstractions.NumberValueProvider;

namespace IsEven.Implementation.NumberValueProvider
{
    internal class IsEvenAlgorithmNumberValueProvider : IIsEvenAlgorithmNumberValueProvider
    {
        public int Zero => 0;
        public int One => 1;
        public int Two => 2;
        public int Four => 4;
        public int Six => 6;
        public int Eight => 8;
    }
}