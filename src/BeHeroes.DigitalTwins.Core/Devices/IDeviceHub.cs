using BeHeroes.CodeOps.Abstractions.Repositories;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    public interface IDeviceHub : IActor, IRepository<IDeviceRegistration>
    {
        new ActorType ActorType => ActorType.System;

        IDeviceClient GetDeviceClient(IDeviceRegistration registration);
    }
}
