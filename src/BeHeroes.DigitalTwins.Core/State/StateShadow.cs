namespace BeHeroes.DigitalTwins.Core.State
{
    /// <summary>
    /// Represents the shadow state of a digital twin.
    /// </summary>
    public record StateShadow(IEnumerable<KeyValuePair<string, object>> Data, IEnumerable<KeyValuePair<string, object>> PreviousData, IEnumerable<KeyValuePair<string, object>> Metadata, IEnumerable<KeyValuePair<string, object>> PreviousMetadata, int Version, int PeerVersion) : State(Data, PreviousData, Metadata, PreviousMetadata, Version), IStateShadow
    {
    }
}