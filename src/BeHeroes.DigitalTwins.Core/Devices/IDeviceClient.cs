using BeHeroes.CodeOps.Abstractions.Facade;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a client for a device in the digital twins system.
    /// </summary>
    public interface IDeviceClient : IFacade, IActor
    {
        new ActorType ActorType => ActorType.User | ActorType.External;        
    }
}
