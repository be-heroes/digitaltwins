using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a prototype for creating replicas of a specific type.
    /// </summary>
    /// <typeparam name="T">The type of replica to create.</typeparam>
    public interface IReplicaPrototype<T> where T : IReplica
    {
        /// <summary>
        /// Creates a new replica instance with the specified state context and decentralized identifier.
        /// </summary>
        /// <param name="context">The state context to use for creating the replica.</param>
        /// <param name="identifier">The decentralized identifier to use for the replica.</param>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation that returns the created replica instance.</returns>
        ValueTask<T> Create(ISynchronizationContext context, DecentralizedIdentifier identifier);
    }
}