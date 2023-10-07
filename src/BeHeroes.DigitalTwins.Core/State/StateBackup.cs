namespace BeHeroes.DigitalTwins.Core.State
{
    /// <summary>
    /// Represents the backup shadow state of a digital twin.
    /// </summary>
    public sealed record StateBackup(IEnumerable<KeyValuePair<string, object>> Data, IEnumerable<KeyValuePair<string, object>> PreviousData, IEnumerable<KeyValuePair<string, object>> Metadata, IEnumerable<KeyValuePair<string, object>> PreviousMetadata, int Version, int PeerVersion) : StateShadow(Data, PreviousData, Metadata, PreviousMetadata, Version, PeerVersion), IStateBackup
    {
    }
}