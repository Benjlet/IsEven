using IsEven.Implementation.Abstractions;

namespace IsEven.Implementation.ZeroIsEven
{
    internal class IsEvenZeroIsEvenYes : IIsEvenZeroIsEven
    {
        public bool IsZeroEven => true;
    }
}