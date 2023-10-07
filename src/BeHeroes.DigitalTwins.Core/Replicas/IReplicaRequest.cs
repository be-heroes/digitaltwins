using BeHeroes.CodeOps.Abstractions.Commands;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IReplicaRequest : ICommand<IReplicaResponse>
    {
    }
}