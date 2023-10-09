namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a synchronization context for a given state differential.
    /// </summary>
    public interface ISynchronizationContext : IDifferentialSynchronizer<IStateDifferential>
    {
    }
}
