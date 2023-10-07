using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.CodeOps.Abstractions.Services;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a service broker that acts as a system actor and handles provisioning requests and events.
    /// </summary>
    public interface IServiceBroker : IActor, IService, ICommandHandler<IProvisioningRequest, IProvisioningResponse>, IEventHandler<IProvisioningEvent>
    {
        new ActorType ActorType => ActorType.System;
    }
}
