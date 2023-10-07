namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Interface for a state sequencer, which generates a sequence of seeds to be used for state initialization.
    /// </summary>
    public interface IStateSequencer
    {
        /// <summary>
        /// Gets the current seed in the sequence.
        /// </summary>
        /// <returns>The current seed.</returns>
        ulong CurrentSeed();
        
        /// <summary>
        /// Gets the next seed in the sequence.
        /// </summary>
        /// <returns>The next seed.</returns>
        ulong NextSeed();

        /// <summary>
        /// Resets the state sequencer to its initial state.
        /// </summary>
        void Reset();
    }
}
