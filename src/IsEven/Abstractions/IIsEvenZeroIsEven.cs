namespace IsEven.Abstractions
{
    /// <summary>
    /// IIsEvenZeroIsEven - abstraction for whether 0 should be considered even or not.
    /// </summary>
    public interface IIsEvenZeroIsEven
    {
        /// <summary>
        /// Whether 0 should be considered even or not.
        /// </summary>
        public bool IsZeroEven { get; }
    }
}