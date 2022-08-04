using IsEven.Abstractions;

namespace IsEven.Implementation.ZeroIsEven
{
    internal class IsEvenZeroIsEvenNo : IIsEvenZeroIsEven
    {
        public bool IsZeroEven => false;
    }
}