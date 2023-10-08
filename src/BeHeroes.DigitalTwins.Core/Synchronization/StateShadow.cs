using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow of a state object, which is used to track changes to the state on a peer.
    /// </summary>
    public sealed class StateShadow : State, IStateShadow
    {
        /// <summary>
        /// The version of the state on the peer that this shadow represents.
        /// </summary>
        private BigInteger peerVersion = default!;

        /// <summary>
        /// Gets or sets the version number of the peer.
        /// </summary>
        public BigInteger PeerVersion { get => peerVersion; set => peerVersion = value; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StateShadow"/> class.
        /// </summary>
        /// <param name="data">The current state data.</param>
        /// <param name="version">The version of the current state data.</param>
        /// <param name="previousData">The previous state data.</param>
        public StateShadow(object data, BigInteger version, object? previousData) : base(data, version, previousData)
        {
        }
    }
}