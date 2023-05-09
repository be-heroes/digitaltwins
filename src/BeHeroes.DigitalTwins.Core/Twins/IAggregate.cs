using BeHeroes.CodeOps.Abstractions.Commands;
using BeHeroes.CodeOps.Abstractions.Events;
using BeHeroes.DigitalTwins.Core.Interfaces;

namespace BeHeroes.DigitalTwins.Core.Twins
{
    public interface IAggregate : IActor, IEventHandler<IAggregateEvent>, ICommandHandler<IInstanceRequest, IInstanceResponse>
    {
        IReadOnlyCollection<IInstance>? GetInstances();
    }
}