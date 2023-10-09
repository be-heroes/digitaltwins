using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents a provisioning request.
    /// </summary>
    public interface IProvisioningRequest : ICommand<IProvisioningResponse>
    {
    }
}
