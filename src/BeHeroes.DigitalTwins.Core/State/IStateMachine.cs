namespace BeHeroes.DigitalTwins.Core.State
{
    /// <summary>
    /// Represents a state machine that can transition between different states.
    /// </summary>
    public interface IStateMachine
    {
        IStateTracker StateTracker { get; }

        IState State { get; }

        IStateShadow StateShadow { get; }

        IStateBackup StateBackup { get; }
    }
}
