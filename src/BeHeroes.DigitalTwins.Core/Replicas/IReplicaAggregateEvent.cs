using BeHeroes.CodeOps.Abstractions.Events;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents an event that is raised when a replica aggregate is updated.
    /// </summary>
    public interface IReplicaAggregateEvent : IIntegrationEvent
    {
    }
}
