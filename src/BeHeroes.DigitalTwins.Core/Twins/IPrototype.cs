using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.State;

namespace BeHeroes.DigitalTwins.Core.Twins
{
    public interface IPrototype<T> where T : IInstance
    {
        ValueTask<T> Create(IStateMachine stateMachine, DecentralizedIdentifier identifier);
    }
}