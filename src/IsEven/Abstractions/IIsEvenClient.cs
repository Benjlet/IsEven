using System.Numerics;

namespace IsEven.Abstractions
{
    /// <summary>
    /// Robust, extensible client for determining if a number is even, odd, or neither even nor odd.
    /// </summary>
    public interface IIsEvenClient
    {
        /// <summary>
        /// Calculates if the supplied number is even, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for even-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for even-ness evaluation.</param>
        /// <returns>
        /// <c>true</c> if the number is even. <c>false</c> if the number is either:<para></para>
        /// a) odd<para></para>
        /// b) not an integer, where <see cref="IIsEvenClientSettings.IntegersOnly"/> is <c>true</c>.
        /// </returns>
        public bool IsEven<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>;

        /// <summary>
        /// Calculates if the supplied number is odd, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for odd-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for odd-ness evaluation.</param>
        /// <returns>
        /// <c>true</c> if the number is odd. <c>false</c> if the number is either:<para></para>
        /// a) even<para></para>
        /// b) not an integer, where <see cref="IIsEvenClientSettings.IntegersOnly"/> is <c>true</c>.
        /// </returns>
        public bool IsOdd<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>;

        /// <summary>
        /// Calculates if the supplied number is either odd or even, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for odd-or-even-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for odd-or-even-ness evaluation.</param>
        /// <returns>
        /// <c>true</c> if the number is either odd or even. <c>false</c> if the number is:<para></para>
        /// a) not odd or even<para></para>
        /// b) not an integer, where <see cref="IIsEvenClientSettings.IntegersOnly"/> is <c>true</c>.
        /// </returns>
        public bool IsOddOrEven<T>(T number, AlgorithmType algorithmType = AlgorithmType.Modulus) where T : INumber<T>, IModulusOperators<T, T, T>;
    }
}