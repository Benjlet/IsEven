using IsEven.Abstractions;

namespace IsEven.Implementation.ZeroIsEven
{
    internal class IsEvenZeroIsEvenYes : IIsEvenZeroIsEven
    {
        public bool IsZeroEven => true;
    }
}