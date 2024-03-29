using System.Numerics;
using BeHeroes.CodeOps.Abstractions.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// The StateSequencer is responsible for generating and tracking sequence numbers used for state synchronization.
    /// </summary>
    public sealed class StateSequencer : Sequencer, IStateSequencer
    {
        /// <summary>
        /// Gets the next value from the sequencer.
        /// </summary>
        /// <returns>The new seed value.</returns>
        public override BigInteger Next() { 
            _next = (_current.HasValue && _current.Value >= DateTime.UtcNow.Ticks) ? _current.Value + 1 : DateTime.UtcNow.Ticks;
            _current = _next;

            return _next;
        }
    }
}