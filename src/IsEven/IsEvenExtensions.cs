namespace IsEven
{
    /// <summary>
    /// Extensions for determining if a number is even, odd, or neither even nor odd.
    /// </summary>
    public static class IsEvenExtensions
    {
        /// <summary>
        /// Calculates if the provided number is even, using Modulo division.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument does not pass validation.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true and not even - or odd, as one could infer - is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public static bool IsEven(this int number) =>
            IsEvenCalculator.IsEven(number);

        /// <summary>
        /// Calculates if the provided number is even, using a specific algorithm.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <param name="algorithmType">The type of algorithm to use for determining the even-ness of the number, Modulus by default.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument does not pass validation.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true and not even - or odd, as one could infer - is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public static bool IsEven(this int number, AlgorithmType algorithmType) =>
            IsEvenCalculator.IsEven(number, algorithmType);

        /// <summary>
        /// Calculates if the provided number is odd, using Modulo division.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument does not pass validation.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true and Even is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public static bool IsOdd(this int number) =>
            IsEvenCalculator.IsOdd(number);

        /// <summary>
        /// Calculates if the provided number is odd, using a specific algorithm.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <param name="algorithmType">The type of algorithm to use for determining the odd-ness of the number, Modulus by default.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument does not pass validation.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true and Even is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public static bool IsOdd(this int number, AlgorithmType algorithmType) =>
            IsEvenCalculator.IsOdd(number, algorithmType);

        /// <summary>
        /// Calculates if the provided number is either odd or even.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <returns>
        /// A boolean value, indicating if the number is odd (true), even (true), or not odd-or-even (false).
        /// </returns>
        public static bool IsOddOrEven(this int number) =>
            IsEvenCalculator.IsOddOrEven(number);
    }
}