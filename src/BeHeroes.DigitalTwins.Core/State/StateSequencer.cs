namespace BeHeroes.DigitalTwins.Core.State
{
    /// <summary>
    /// A class that generates a sequence of seeds for use in state management.
    /// </summary>
    public sealed class StateSequencer : IStateSequencer
    {
        /// <summary>
        /// The seed used for generating the next state in the sequence.
        /// </summary>
        ulong _seed = 0;

        /// <summary>
        /// Returns the current seed value used by the state sequencer.
        /// </summary>
        /// <returns>The current seed value.</returns>
        public ulong CurrentSeed() => _seed;

        /// <summary>
        /// Returns the next seed value for generating state sequences.
        /// </summary>
        /// <returns>The next seed value.</returns>
        public ulong NextSeed() => ++_seed;

        /// <summary>
        /// Resets the seed value to 0.
        /// </summary>
        public void Reset() => _seed = 0;
    }
}