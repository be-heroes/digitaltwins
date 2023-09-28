using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateMachine
    {
        IImmutableQueue<IState> ChangeTracker { get; }

        IStateSequencer StateSequencer { get; }

        IKnownState KnownState { get; init; }

        IShadowState ShadowState { get; init; }

        IShadowState BackupShadowState { get; }
    }
}
