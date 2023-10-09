using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow state differential of a state differential.
    /// </summary>
    public interface IStateDifferentialShadow : IStateDifferential
    {
        /// <summary>
        /// Gets the version number of the peer that last updated the shadow state.
        /// </summary>
        BigInteger PeerVersion { get; }
    }
}
