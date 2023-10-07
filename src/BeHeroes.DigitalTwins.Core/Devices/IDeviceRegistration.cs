using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    /// <summary>
    /// Represents a device registration in the system.
    /// </summary>
    public interface IDeviceRegistration : IAggregateRoot
    {
        DecentralizedIdentifier Identifier { get; }

        string ConnectionString { get; }
    }
}
