using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow state of a digital twin. A shadow state is a copy of the state of a digital twin that is stored in the cloud and is used to synchronize the state of the twin with its corresponding physical device.
    /// </summary>
    public interface IStateShadow : IState
    {
        /// <summary>
        /// Gets or sets the version number of the peer that last updated the shadow state.
        /// </summary>
        BigInteger PeerVersion { get; set; }
    }
}
