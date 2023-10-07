namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateMachine
    {
        IStateTracker StateTracker { get; }

        IKnownState KnownState { get; init; }

        IStateShadow StateShadow { get; init; }

        IStateBackup StateBackup { get; }
    }
}
