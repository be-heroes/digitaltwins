using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Data;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a replica of a digital twin. A replica is an instance of a digital twin that can be used to perform operations on the twin.
    /// </summary>
    public interface IReplica : IActor, IView, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        new ActorType ActorType => ActorType.System;
    }
}