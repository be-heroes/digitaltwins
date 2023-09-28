using BeHeroes.CodeOps.Abstractions;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public class Instance : Disposable, IInstance
    {
        public ActorType ActorType => ActorType.System | ActorType.User;

        public DecentralizedIdentifier Identifier => throw new NotImplementedException();

        public IKey? SecurityKey => throw new NotImplementedException();

        public ActorStatus ActorStatus => throw new NotImplementedException();

        public KeyValuePair<string, string>? GetResourcePrincipal()
        {
            throw new NotImplementedException();
        }

        public Task<IInstanceResponse> Handle(IInstanceRequest request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}