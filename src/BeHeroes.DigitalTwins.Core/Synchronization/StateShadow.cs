namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the shadow state of a digital twin.
    /// </summary>
    public sealed class StateShadow : State, IStateShadow
    {
        private ulong peerVersion = default!;

        /// <summary>
        /// Gets or sets the version number of the peer.
        /// </summary>
        public ulong PeerVersion { get => peerVersion; set => peerVersion = value; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StateShadow"/> class.
        /// </summary>
        /// <param name="data">The current state data.</param>
        /// <param name="version">The version of the current state data.</param>
        /// <param name="previousData">The previous state data.</param>
        public StateShadow(object data, ulong version, object? previousData) : base(data, version, previousData)
        {
        }
    }
}