using System.Net;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    public interface IDeviceResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
