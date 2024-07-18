using IsEven.Abstractions;

namespace IsEven.Implementation.Service
{
    internal class IsEvenClientDefaultSettings : IIsEvenClientSettings
    {
        public bool IsZeroEven { get; set; } = true;
        public bool IntegersOnly { get; set; } = true;
        public bool IgnoreDecimalDigits { get; set; } = false;
    }
}
