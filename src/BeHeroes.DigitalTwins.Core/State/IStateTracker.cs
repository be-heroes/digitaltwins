using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateTracker : IImmutableQueue<IState>
    {
        IStateSequencer StateSequencer { get; }
    }
}
