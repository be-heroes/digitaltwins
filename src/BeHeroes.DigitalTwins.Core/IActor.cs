using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core
{
    public interface IActor : IDisposable, IAsyncDisposable
    {
        DecentralizedIdentifier Identifier { get; }

        IKey? SecurityKey { get; }

        ActorType ActorType => ActorType.None;

        ActorStatus ActorStatus { get; }
        
        KeyValuePair<string, string>? GetResourcePrincipal();
    }
}
