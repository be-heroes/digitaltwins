using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential that can be used for differential synchronization.
    /// </summary>
    public interface IDifferential
    {
        /// <summary>
        /// Gets the version of the differential.
        /// </summary>
        BigInteger Version { get; }        
    }
}
