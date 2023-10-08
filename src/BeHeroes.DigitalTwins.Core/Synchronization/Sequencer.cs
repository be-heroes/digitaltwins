namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Numerics namespace
    /// <summary>
    /// The sequencer is responsible for generating and tracking sequence numbers used for state synchronization.
    /// </summary>
    public sealed class Sequencer : ISequencer
    {
        /// <summary>
        /// The current value of the sequencer.
        /// </summary>
        private long? _current = default!;

        /// <summary>
        /// The next value to be used by the sequencer.
        /// </summary>
        private long _next = 1;

        /// <summary>
        /// Gets the current value from the sequencer.
        /// </summary>
        /// <returns>The current seed value.</returns>
        public long? Current() => _current;

        /// <summary>
        /// Gets the next value from the sequencer.
        /// </summary>
        /// <returns>The new seed value.</returns>
        public long Next() { 
            _current = _next;

            return _next++;
        }

        /// <summary>
        /// Resets the sequencer.
        /// </summary>
        public void Reset() {
            _current = null;
            _next = 1;
        }
    }
}