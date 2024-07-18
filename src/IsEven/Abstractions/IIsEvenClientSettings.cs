namespace IsEven.Abstractions
{
    /// <summary>
    /// Settings for the IsEven client.
    /// </summary>
    public interface IIsEvenClientSettings
    {
        /// <summary>
        /// Whether zero should be considered even - this is apparently contentious to some and the configuration avoids such arguments.
        /// </summary>
        public bool IsZeroEven { get; set; }

        /// <summary>
        /// Whether non-integers should be considered. <c>false</c> is returned for non-integer values if this is enabled.
        /// </summary>
        public bool IntegersOnly { get; set; }

        /// <summary>
        /// Whether decimal digits should be ignored.
        /// <see cref="IntegersOnly"/> will need enabling in these cases. 
        /// For example, <c>502.8d</c> would be considered <c>502</c> and therefore even.
        /// </summary>
        public bool IgnoreDecimalDigits { get; set; }
    }
}