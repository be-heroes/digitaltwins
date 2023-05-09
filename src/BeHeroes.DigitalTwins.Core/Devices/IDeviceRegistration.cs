using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Devices
{
    public interface IDeviceRegistration : IAggregateRoot
    {
        DecentralizedIdentifier Identifier { get; }

        string ConnectionString { get; }
    }
}
