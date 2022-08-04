namespace IsEven.Abstractions.NumberValueProvider
{
    /// <summary>
    /// Provides the integer value equivalents of each number used, abstracted in case our known understanding of numerals were to fundamentally change.
    /// </summary>
    internal interface IIsEvenAlgorithmNumberValueProvider
    {
        /// <summary>
        /// Zero.
        /// </summary>
        public int Zero { get; }

        /// <summary>
        /// One.
        /// </summary>
        public int One { get; }

        /// <summary>
        /// Two.
        /// </summary>
        public int Two { get; }
    }
}