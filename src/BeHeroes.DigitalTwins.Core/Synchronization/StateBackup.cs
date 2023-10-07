namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the backup shadow state of a digital twin.
    /// </summary>
    public sealed record StateBackup(object Data, int Version, int PeerVersion, object? PreviousData) : StateShadow(Data, Version, PeerVersion, PreviousData), IStateBackup
    {
    }
}