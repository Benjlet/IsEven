using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    /// <summary>
    /// IIsEvenRequestValidator - validation handling for supplied integers.
    /// </summary>
    public interface IIsEvenRequestValidator
    {
        /// <summary>
        /// Validates the supplied integer.
        /// </summary>
        /// <param name="number">The number to validate.</param>
        /// <returns>The validation result.</returns>
        public IIsEvenValidationResponse Validate(int number);
    }
}