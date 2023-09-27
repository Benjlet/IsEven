using IsEven.Implementation.Abstractions;

namespace IsEven.Implementation.Service
{
    internal class IsEvenClientSettings : IIsEvenClientSettings
    {
        public bool IsZeroEven { get; set; } = false;
        public bool IntegersOnly { get; set; } = true;
        public bool IgnoreDecimalDigits { get; set; } = false;
    }
}
