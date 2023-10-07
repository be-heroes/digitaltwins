using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a device in the digital twin system.
    /// </summary>
    public interface IDevice : IActor, IAggregateRoot, ICommandHandler<IDeviceRequest, IDeviceResponse>, IEventHandler<IDeviceEvent>
    {
        /// <summary>
        /// Gets the type of actor for this device.
        /// </summary>
        new ActorType ActorType => ActorType.System | ActorType.External;
    }
}
