using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Data;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a replica of a digital twin. A replica is a "mirror" of a digital twin that can be used to perform operations on the physical asset.
    /// </summary>
    public interface IReplica : IActor, IView, ICommandHandler<IReplicaRequest, IReplicaResponse>
    {
        /// <summary>
        /// Gets the type of the actor.
        /// </summary>
        new ActorType ActorType => ActorType.System;
    }
}