using System.Linq.Expressions;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Data;
using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.CodeOps.Abstractions.Repositories;
using BeHeroes.DigitalTwins.Core;
using BeHeroes.DigitalTwins.Core.Devices;
using BeHeroes.DigitalTwins.Core.Provisioning;

namespace BeHeroes.DigitalTwins.Infrastructure.Azure.Devices
{
    public abstract class AzureBroker<TContext> : Repository<TContext, IDevice>, IServiceBroker where TContext : class, IUnitOfWork
    {
        public DecentralizedIdentifier Identifier => throw new NotImplementedException();

        public IKey? SecurityKey => throw new NotImplementedException();

        public ActorStatus ActorStatus => throw new NotImplementedException();

        protected AzureBroker(TContext context) : base(context)
        {
        }

        public KeyValuePair<string, string>? GetResourcePrincipal()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IProvisioningResponse> Handle(IProvisioningRequest request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Handle(IProvisioningEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}