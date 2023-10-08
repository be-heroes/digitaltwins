using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Numerics namespace
    /// <summary>
    /// Defines an interface for a sequencer that generates a sequence of incrementing values.
    /// </summary>
    public interface ISequencer
    {
        /// <summary>
        /// Gets the current value from the sequence.
        /// </summary>
        /// <returns>The current seed.</returns>
        BigInteger? Current();
        
        /// <summary>
        /// Gets the next value from the sequence.
        /// </summary>
        /// <returns>The next seed.</returns>
        BigInteger Next();

        /// <summary>
        /// Resets the sequencer.
        /// </summary>
        void Reset();
    }
}
