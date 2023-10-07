using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.State;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    public interface IReplicaPrototype<T> where T : IReplica
    {
        ValueTask<T> Create(IStateMachine stateMachine, DecentralizedIdentifier identifier);
    }
}