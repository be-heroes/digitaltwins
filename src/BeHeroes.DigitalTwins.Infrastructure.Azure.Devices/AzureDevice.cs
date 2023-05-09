using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core;
using BeHeroes.DigitalTwins.Core.Devices;

namespace BeHeroes.DigitalTwins.Infrastructure.Azure.Devices
{
    public abstract class AzureDevice : AggregateRoot<Guid>, IDevice
    {
        public DecentralizedIdentifier Identifier => throw new NotImplementedException();

        public IKey? SecurityKey => throw new NotImplementedException();

        public ActorStatus ActorStatus => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string>? GetResourcePrincipal()
        {
            throw new NotImplementedException();
        }

        public Task<IDeviceResponse> Handle(IDeviceRequest request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Handle(IDeviceEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}