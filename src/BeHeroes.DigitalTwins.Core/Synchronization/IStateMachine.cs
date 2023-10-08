namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state machine that synchronizes differential updates of a state.
    /// </summary>
    public interface IStateMachine : IDifferentialSynchronizer<IState>
    {
    }
}
