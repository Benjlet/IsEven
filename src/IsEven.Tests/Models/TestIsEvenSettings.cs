using IsEven.Implementation.Abstractions;

namespace IsEven.Tests.Models
{
    internal class TestIsEvenSettings : IIsEvenClientSettings
    {
        public bool IsZeroEven { get; set; }
        public bool IntegersOnly { get; set; }
        public bool IgnoreDecimalDigits { get; set; }
    }
}
