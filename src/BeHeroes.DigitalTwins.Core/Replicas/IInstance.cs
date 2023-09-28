using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IInstance : IActor, ICommandHandler<IInstanceRequest, IInstanceResponse>
    {
        new ActorType ActorType => ActorType.System | ActorType.User;
    }
}