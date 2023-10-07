using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a request made to a device.
    /// </summary>
    public interface IDeviceRequest : ICommand<IDeviceResponse>
    {
    }
}
