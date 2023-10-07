using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a request to provision a digital twin.
    /// </summary>
    public interface IProvisioningRequest : ICommand<IProvisioningResponse>
    {
    }
}
