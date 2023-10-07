using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents an aggregate of replicas, which is responsible for handling replica-related commands and events.
    /// </summary>
    public interface IReplicaAggregate : IActor, IAggregateRoot, IEventHandler<IReplicaAggregateEvent>, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        /// <summary>
        /// Gets the replica with the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the replica to get.</param>
        /// <returns>A <see cref="ValueTask{TResult}"/> that represents the asynchronous operation. The task result contains the replica with the specified identifier, or <c>null</c> if no such replica exists.</returns>
        ValueTask<IReplica>? GetReplica(DecentralizedIdentifier identifier);

        /// <summary>
        /// Gets all replicas in the aggregate.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TResult}"/> that represents the asynchronous operation. The task result contains a read-only collection of all replicas in the aggregate.</returns>
        ValueTask<IReadOnlyCollection<IReplica>>? GetReplicas();
    }
}