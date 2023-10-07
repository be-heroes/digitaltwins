using System.Reflection.Metadata.Ecma335;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// A class that generates a sequence of seeds for use in state management.
    /// </summary>
    public sealed class StateSequencer : IStateSequencer
    {
        /// <summary>
        /// The seed used for generating the next state in the sequence.
        /// </summary>
        private ulong _seed = 0;

        /// <summary>
        /// The pending seed used for tracing the expected return seed from an external synchronization peer.
        /// </summary>
        private ulong? _pendingSeed = default!;

        /// <summary>
        /// Returns the current seed value used by the state sequencer.
        /// </summary>
        /// <returns>The current seed value.</returns>
        public ulong? PendingSeed() => _pendingSeed;

        /// <summary>
        /// Returns the next seed value for generating state sequences.
        /// </summary>
        /// <returns>The next seed value.</returns>
        public ulong NextSeed() { 
            _pendingSeed = _seed;
            
            return _seed++;
        }

        /// <summary>
        /// Resets the sequencer.
        /// </summary>
        public void Reset() {
            _seed = 0;
            _pendingSeed = null;
        }
    }
}