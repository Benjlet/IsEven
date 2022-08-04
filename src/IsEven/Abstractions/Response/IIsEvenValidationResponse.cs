namespace IsEven.Abstractions.Response
{
    /// <summary>
    /// IIsEvenValidationResponse - validation response for whether the number is even or not.
    /// </summary>
    public interface IIsEvenValidationResponse
    {
        /// <summary>
        /// Whether the number is even or not.
        /// </summary>
        public bool IsValid { get; }
    }
}