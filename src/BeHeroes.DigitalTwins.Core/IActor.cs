using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core
{
    /// <summary>
    /// Represents an actor in the digital twin system.
    /// </summary>
    public interface IActor : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Gets the decentralized identifier of the actor.
        /// </summary>
        DecentralizedIdentifier Identifier { get; }

        /// <summary>
        /// Gets the security key of the actor.
        /// </summary>
        IKey? SecurityKey { get; }

        /// <summary>
        /// Gets the type of the actor.
        /// </summary>
        ActorType ActorType => ActorType.None;

        /// <summary>
        /// Gets the status of the actor.
        /// </summary>
        ActorStatus ActorStatus { get; }
        
        /// <summary>
        /// Gets the resource principal of the actor.
        /// </summary>
        KeyValuePair<string, string>? GetResourcePrincipal();
    }
}
