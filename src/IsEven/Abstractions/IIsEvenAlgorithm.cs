using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    /// <summary>
    /// IIsEvenAlgorithm - algorithm for calculating if the number is even or not.
    /// </summary>
    public interface IIsEvenAlgorithm
    {
        /// <summary>
        /// Calculates whether the number is even and returns the output.
        /// </summary>
        /// <param name="number">The number to validate.</param>
        /// <returns>
        /// An abstracted IIsEvenAlgorithmResponse.
        /// </returns>
        public IIsEvenAlgorithmResponse Calculate(int number);
    }
}