using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a tracker for the state of an entity in a digital twin system.
    /// </summary>
    public interface IStateTracker : IImmutableQueue<IState>
    {
        /// <summary>
        /// Gets the sequencer for the state tracker.
        /// </summary>
        IStateSequencer StateSequencer { get; }
    }
}
