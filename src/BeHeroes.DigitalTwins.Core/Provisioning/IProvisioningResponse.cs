using System.Net;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    public interface IProvisioningResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
