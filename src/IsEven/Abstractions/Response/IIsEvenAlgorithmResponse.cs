namespace IsEven.Abstractions.Response
{
    /// <summary>
    /// IIsEvenAlgorithmResponse - the response for whether the algorithm has determined the supplied number is even or not.
    /// </summary>
    public interface IIsEvenAlgorithmResponse
    {
        /// <summary>
        /// Whether the number is even or not.
        /// </summary>
        public bool IsEven { get; }
    }
}