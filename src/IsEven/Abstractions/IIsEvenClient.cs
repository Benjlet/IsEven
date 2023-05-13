namespace IsEven.Abstractions
{
    /// <summary>
    /// Service client for determining if a number is even, odd, or neither even nor odd.
    /// </summary>
    public interface IIsEvenClient
    {
        /// <summary>
        /// Calculates if the specified number is even.
        /// </summary>
        /// <param name="number">The number for even-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true; not even (or odd, as one could infer) is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number);

        /// <summary>
        /// Calculates if the specified number is even, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for even-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for even-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true; not even (or odd, as one could infer) is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number, AlgorithmType algorithmType);

        /// <summary>
        /// Calculates if the specified number is odd.
        /// </summary>
        /// <param name="number">The number for odd-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true; not odd (or even, as one could infer) is represented by false.
        /// Take, for example, the number 1, which is returned as true; 2, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number);

        /// <summary>
        /// Calculates if the specified number is odd, using the supplied algorithm type.
        /// </summary>
        /// <param name="number">The number for odd-ness evaluation.</param>
        /// <param name="algorithmType">The algorithm to use for odd-ness evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true; not odd (or even, as one could infer) is represented by false.
        /// Take, for example, the number 1, which is returned as true; 2, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number, AlgorithmType algorithmType);

        /// <summary>
        /// Calculates if the specified number is either odd or even.
        /// </summary>
        /// <param name="number">The number for evaluation.</param>
        /// <returns>
        /// True/false: a boolean value, indicating whether the integer is either odd or even.
        /// </returns>
        public bool IsOddOrEven(int number);
    }
}