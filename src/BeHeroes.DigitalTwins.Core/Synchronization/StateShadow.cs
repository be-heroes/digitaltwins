namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the shadow state of a digital twin.
    /// </summary>
    public record StateShadow(object Data, int Version, int PeerVersion, object? PreviousData) : State(Data, Version, PreviousData), IStateShadow
    {
    }
}