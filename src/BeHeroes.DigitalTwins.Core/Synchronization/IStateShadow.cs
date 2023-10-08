using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow state that is used to synchronize data between peers.
    /// </summary>
    public interface IStateShadow : IState
    {
        /// <summary>
        /// Gets or sets the version number of the peer that last updated the shadow state.
        /// </summary>
        BigInteger PeerVersion { get; set; }
    }
}
