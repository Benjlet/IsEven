namespace IsEven.Abstractions
{
    /// <summary>
    /// IIsEvenCalculator - main abstraction for calculating if a number is even, odd, or neither even nor odd.
    /// </summary>
    public interface IIsEvenCalculator
    {
        /// <summary>
        /// Calculates if the provided number is even.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true and not even - or odd, as one could infer - is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number);

        /// <summary>
        /// Calculates if the provided number is odd.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true and Even is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number);

        /// <summary>
        /// Calculates if the provided number is either odd or even.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <returns>
        /// A boolean value, indicating if the number is odd (true), even (true), or not odd-or-even (false).
        /// </returns>
        public bool IsOddOrEven(int number);
    }
}