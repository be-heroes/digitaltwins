using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Entities;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public abstract class Replica : ValueObject, IDisposable, IAsyncDisposable, IReplica
    {
        public ActorType ActorType => ActorType.System;

        public DecentralizedIdentifier Identifier => throw new NotImplementedException();

        public IKey? SecurityKey => throw new NotImplementedException();

        public ActorStatus ActorStatus => throw new NotImplementedException();

        public abstract KeyValuePair<string, string>? GetResourcePrincipal();

        public abstract Task<IReplicaResponse> Handle(IReplicaRequest request, CancellationToken cancellationToken = default);

        protected abstract void Dispose(bool disposing);

        public void Dispose()
        {
            Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        public ValueTask DisposeAsync()
        {
            Dispose();

            return ValueTask.CompletedTask;
        }
    }
}