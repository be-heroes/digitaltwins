namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a digital twin.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Gets or sets the data of the digital twin.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> Data { get; init; }

        /// <summary>
        /// Gets the previous data of the digital twin.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> PreviousData { get; }

        /// <summary>
        /// Gets or sets the metadata of the digital twin.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> Metadata { get; init; }

        /// <summary>
        /// Gets the previous metadata of the digital twin.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> PreviousMetadata { get; }

        /// <summary>
        /// Gets or sets the version of the digital twin.
        /// </summary>
        int Version { get; init; }
    }
}
