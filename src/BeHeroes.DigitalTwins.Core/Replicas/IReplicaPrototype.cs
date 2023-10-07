using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.State;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a prototype for creating replicas of a specific type.
    /// </summary>
    /// <typeparam name="T">The type of replica to create.</typeparam>
    public interface IReplicaPrototype<T> where T : IReplica
    {
        /// <summary>
        /// Creates a new replica instance with the specified state machine and decentralized identifier.
        /// </summary>
        /// <param name="stateMachine">The state machine to use for the replica.</param>
        /// <param name="identifier">The decentralized identifier for the replica.</param>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation, containing the new replica instance.</returns>
        ValueTask<T> Create(IStateMachine stateMachine, DecentralizedIdentifier identifier);
    }
}