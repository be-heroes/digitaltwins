using BeHeroes.CodeOps.Abstractions.Events;

namespace BeHeroes.DigitalTwins.Core.Provisioning
{
    /// <summary>
    /// Represents an event that is raised when a provisioning request is processed.
    /// </summary>
    public interface IProvisioningEvent : IIntegrationEvent
    {
    }
}
