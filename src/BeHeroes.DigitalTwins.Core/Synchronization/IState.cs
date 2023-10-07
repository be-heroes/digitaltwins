namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a digital twin.
    /// </summary>
    public interface IState : IStateDifferential
    {
        /// <summary>
        /// Gets or sets the data of the digital twin.
        /// </summary>
        object Data { get; init; }

        /// <summary>
        /// Gets the previous data of the digital twin.
        /// </summary>
        object? PreviousData { get; }
    }
}
