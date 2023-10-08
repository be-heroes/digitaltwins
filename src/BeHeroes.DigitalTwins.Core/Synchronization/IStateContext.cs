namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a context for synchronizing the state of a digital twin.
    /// </summary>
    public interface IStateContext : IDifferentialSynchronizer<IState>
    {
    }
}
