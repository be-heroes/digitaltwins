namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a digital twin.
    /// </summary>
    public record State(IEnumerable<KeyValuePair<string, object>> Data, IEnumerable<KeyValuePair<string, object>> PreviousData, IEnumerable<KeyValuePair<string, object>> Metadata, IEnumerable<KeyValuePair<string, object>> PreviousMetadata, int Version) : IState
    {
    }
}