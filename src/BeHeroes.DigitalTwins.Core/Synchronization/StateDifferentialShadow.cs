using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow of a state differential, which is used to track changes to the state on a peer.
    /// </summary>
    public sealed class StateDifferentialShadow : StateDifferential, IStateDifferentialShadow
    {
        /// <summary>
        /// Gets the peer version number.
        /// </summary>
        public BigInteger PeerVersion { get; } = default!;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StateDifferentialShadow"/> class.
        /// </summary>
        /// <param name="data">The current state data.</param>
        /// <param name="version">The version of the current state data.</param>
        /// <param name="previousData">The previous state data.</param>
        public StateDifferentialShadow(object data, BigInteger version, BigInteger peerVersion, object? previousData) : base(data, version, previousData)
        {
            PeerVersion = peerVersion;
        }
    }
}