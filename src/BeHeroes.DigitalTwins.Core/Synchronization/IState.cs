namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a replica.
    /// </summary>
    public interface IState : IDifferential
    {
        /// <summary>
        /// Gets the data of the state object.
        /// </summary>
        ValueTask<object> GetData();

        /// <summary>
        /// Gets the data of the state object before the last state machine transition.
        /// </summary>
        ValueTask<object?> GetPreviousData();
    }
}
