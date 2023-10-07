using System.Net;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a response from a provisioning operation.
    /// </summary>
    public interface IProvisioningResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
