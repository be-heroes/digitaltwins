using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;

namespace BeHeroes.DigitalTwins.Core.Twins
{
    public interface IAggregate : IActor, IEventHandler<IAggregateEvent>, ICommandHandler<IInstanceRequest, IInstanceResponse>
    {
        IReadOnlyCollection<IInstance>? GetInstances();
    }
}