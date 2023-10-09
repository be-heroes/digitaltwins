using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.CodeOps.Abstractions.Services;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a service broker that handles provisioning requests and events.
    /// </summary>
    public interface IServiceBroker : IActor, IService, ICommandHandler<IProvisioningRequest, IProvisioningResponse>, IEventHandler<IProvisioningEvent>
    {
        /// <summary>
        /// Gets the type of the actor.
        /// </summary>
        new ActorType ActorType => ActorType.System;
    }
}
