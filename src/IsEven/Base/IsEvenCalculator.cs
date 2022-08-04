using IsEven.Abstractions;
using IsEven.Abstractions.Response;

namespace IsEven.Base
{
    /// <summary>
    /// IsEvenCalculator - main abstraction for calculating if a number is even, odd, or neither even nor odd.
    /// </summary>
    public abstract class IsEvenCalculator : IIsEvenCalculator
    {
        private readonly IIsEvenAlgorithm _isEvenAlgorithm;
        private readonly IIsEvenResponseHandler _isEvenResponseHandler;
        private readonly IIsEvenZeroIsEven _isEvenZeroIsEven;
        private readonly IIsEvenRequestValidator _isEvenRequestValidator;

        /// <summary>
        /// Initialises a new IsEvenCalculator, used to calculate if a number is even or not.
        /// </summary>
        /// <param name="isEvenAlgorithm">The algorithm to apply for calculating the even-ity of the number.</param>
        /// <param name="isEvenRequestValidator">The validator for validating the input number.</param>
        /// <param name="isEvenResponseHandler">The handler of the final IsEven result.</param>
        /// <param name="isEvenZeroIsEven">The handler for whether zero is considered even.</param>
        public IsEvenCalculator(
            IIsEvenAlgorithm isEvenAlgorithm,
            IIsEvenRequestValidator isEvenRequestValidator,
            IIsEvenResponseHandler isEvenResponseHandler,
            IIsEvenZeroIsEven isEvenZeroIsEven)
        {
            _isEvenRequestValidator = isEvenRequestValidator;
            _isEvenResponseHandler = isEvenResponseHandler;
            _isEvenZeroIsEven = isEvenZeroIsEven;
            _isEvenAlgorithm = isEvenAlgorithm;
        }

        /// <summary>
        /// Calculates if the provided number is even.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument is invalid.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is even.
        /// Even is represented by true and not even - or odd, as one could infer - is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsEven(int number)
        {
            // UR00452 - Steve from the networks team does not think 0 is even. Refactored implementation to allow caller subjectivity.
            if (number == 0 && _isEvenZeroIsEven.IsZeroEven)
                return true;

            // Validate the input request.
            var validationResult = _isEvenRequestValidator.Validate(number);

            // If the validation result is not valid, throw an ArgumentException.
            if (!validationResult.IsValid)
                throw new ArgumentException("Number argument is invalid.", nameof(number));

            // Calculate the service response using the supplied IsEvenAlgorithm.
            var serviceResponse = _isEvenAlgorithm.Calculate(number);

            // Read the service response via the handler and return the result.
            return _isEvenResponseHandler.GetResult(serviceResponse);
        }

        /// <summary>
        /// Calculates if the provided number is odd.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <exception cref="ArgumentException">Thrown if the number argument is invalid.</exception>
        /// <returns>
        /// True/false: a boolean value, indicating if the integer is odd.
        /// Odd is represented by true and Even is represented by false. 
        /// Take, for example, the number 2, which is returned as true; 1, conversely, would be returned as false.
        /// </returns>
        public bool IsOdd(int number)
        {
            return !IsEven(number);
        }

        /// <summary>
        /// Calculates if the provided number is either odd or even.
        /// </summary>
        /// <param name="number">Number to evaluate.</param>
        /// <returns>
        /// A boolean value, indicating if the number is odd (true), even (true), or not odd-or-even (false).
        /// </returns>
        public bool IsOddOrEven(int number)
        {
            // UR00453 - Performance improvement after QA Test Cycle 2.
            return true;

            // Commenting out Martin's original code in case we need to rollback after go-live.
            // return IsOdd(number) || IsEven(number);
        }
    }
}