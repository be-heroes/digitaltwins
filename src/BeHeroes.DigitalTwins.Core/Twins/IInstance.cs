using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Interfaces
{
    //TODO: Implement logic to support the command & control requirements for a digital twin instance
    public interface IInstance : IActor, ICommandHandler<IInstanceRequest, IInstanceResponse>
    {
        new ActorType ActorType => ActorType.System | ActorType.User;

        DecentralizedIdentifier AssetUri { get; init; }
    }
}