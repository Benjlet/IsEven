namespace IsEven
{
    /// <summary>
    /// The type of algorithm to apply for calculating whether a number is even.
    /// </summary>
    public enum AlgorithmType
    {
        /// <summary>
        /// The modulo division algorithm.
        /// </summary>
        Modulus,

        /// <summary>
        /// Character-comparison on the last digit.
        /// </summary>
        LastDigitCheck,

        /// <summary>
        /// Trust .NET.
        /// </summary>
        DotNet
    }
}