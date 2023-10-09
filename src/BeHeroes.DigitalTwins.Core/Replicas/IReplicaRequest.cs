using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a replica request.
    /// </summary>
    public interface IReplicaRequest : ICommand<IReplicaResponse>
    {
    }
}