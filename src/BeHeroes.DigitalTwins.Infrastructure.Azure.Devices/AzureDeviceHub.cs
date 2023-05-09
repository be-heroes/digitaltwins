using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Data;
using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.CodeOps.Abstractions.Repositories;
using BeHeroes.DigitalTwins.Core;
using BeHeroes.DigitalTwins.Core.Devices;

namespace BeHeroes.DigitalTwins.Infrastructure.Azure.Devices
{
    public abstract class AzureDeviceHub<TContext> : Repository<TContext, IDeviceRegistration>, IDeviceHub where TContext : class, IUnitOfWork
    {
        public DecentralizedIdentifier Identifier => throw new NotImplementedException();

        public IKey? SecurityKey => throw new NotImplementedException();

        public ActorStatus ActorStatus => throw new NotImplementedException();

        protected AzureDeviceHub(TContext context) : base(context)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public IDeviceClient GetDeviceClient(IDeviceRegistration registration)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string>? GetResourcePrincipal()
        {
            throw new NotImplementedException();
        }
    }
}