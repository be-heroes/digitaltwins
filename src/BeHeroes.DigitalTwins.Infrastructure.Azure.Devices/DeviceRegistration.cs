using System.ComponentModel.DataAnnotations;
using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.Devices;

namespace BeHeroes.DigitalTwins.Infrastructure.Azure.Devices
{
    public abstract class AzureDeviceRegistration : AggregateRoot<Guid>, IDeviceRegistration
    {
        public DecentralizedIdentifier Identifier { get; init; }

        public string ConnectionString  { get; init; }

        protected AzureDeviceRegistration(DecentralizedIdentifier identifier, string connectionString)
        {
            Identifier = identifier;
            ConnectionString = connectionString;
        }
    }
}