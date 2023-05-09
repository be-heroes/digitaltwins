using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    public interface IDeviceRequest : ICommand<IDeviceResponse>
    {
    }
}
