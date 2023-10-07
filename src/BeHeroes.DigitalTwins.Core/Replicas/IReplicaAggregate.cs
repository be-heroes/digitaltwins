using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IReplicaAggregate : IActor, IAggregateRoot, IEventHandler<IReplicaAggregateEvent>, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        ValueTask<IReplica>? GetReplica(DecentralizedIdentifier identifier);

        ValueTask<IReadOnlyCollection<IReplica>>? GetReplicas();
    }
}