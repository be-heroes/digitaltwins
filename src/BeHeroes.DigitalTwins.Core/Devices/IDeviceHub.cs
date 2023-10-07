using BeHeroes.CodeOps.Abstractions.Repositories;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a hub for managing devices in the system.
    /// </summary>
    public interface IDeviceHub : IActor, IRepository<IDeviceRegistration>
    {
        new ActorType ActorType => ActorType.System;

        /// <summary>
        /// Gets the device client for the specified device registration.
        /// </summary>
        /// <param name="registration">The device registration.</param>
        /// <returns>The device client.</returns>
        IDeviceClient GetDeviceClient(IDeviceRegistration registration);
    }
}
