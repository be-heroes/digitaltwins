using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a shadow state of an entity in the digital twin system. A shadow state is a copy of the state of an entity that is kept in sync with the actual state of the entity.
    /// </summary>
    public interface IStateShadow : IState
    {
        /// <summary>
        /// Gets or sets the version number of the peer that last updated the shadow state.
        /// </summary>
        BigInteger PeerVersion { get; set; }
    }
}
