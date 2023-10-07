using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Data;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IReplica : IActor, IView, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        new ActorType ActorType => ActorType.System;
    }
}