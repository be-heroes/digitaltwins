using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IAggregateReplica : IActor, IAggregateRoot, IEventHandler<IAggregateEvent>, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        ValueTask<IReplica>? GetReplica(DecentralizedIdentifier identifier);

        ValueTask<IReadOnlyCollection<IReplica>>? GetReplicas();
    }
}