using System.Net;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a response from a device.
    /// </summary>
    public interface IDeviceResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
