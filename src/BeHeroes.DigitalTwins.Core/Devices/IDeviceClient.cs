using BeHeroes.CodeOps.Abstractions.Facade;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    public interface IDeviceClient : IFacade, IActor
    {
        new ActorType ActorType => ActorType.User | ActorType.External;        
    }
}
