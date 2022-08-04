namespace IsEven.Abstractions.Response
{
    /// <summary>
    /// IIsEvenResponseHandler - handles the response from the algorithm that has been run against the provided number.
    /// </summary>
    public interface IIsEvenResponseHandler
    {
        /// <summary>
        /// Gets the result of the algorithm and converts it to an 'is even' response.
        /// </summary>
        /// <param name="response">The response from the 'is even' algorithm.</param>
        /// <returns>True/false - whether the number is even or not, based on the algorithm response.</returns>
        public bool GetResult(IIsEvenAlgorithmResponse response);
    }
}