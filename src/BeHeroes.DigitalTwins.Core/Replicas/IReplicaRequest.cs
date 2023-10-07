using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a request for a replica.
    /// </summary>
    public interface IReplicaRequest : ICommand<IReplicaResponse>
    {
    }
}