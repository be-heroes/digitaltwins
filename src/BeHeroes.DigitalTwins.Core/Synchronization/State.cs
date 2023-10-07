namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a digital twin.
    /// </summary>
    public record State(object Data, int Version, object? PreviousData = default) : IState
    {
    }
}