using System.Net;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a provisioning response.
    /// </summary>
    public interface IProvisioningResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
