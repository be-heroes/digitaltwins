using BeHeroes.CodeOps.Abstractions.Identity.Did;

namespace BeHeroes.DigitalTwins.Core.Interfaces
{
    public interface IPrototype<T> where T : IInstance
    {
        ValueTask<T> Create(IDesiredState state, DecentralizedIdentifier identifier);
    }
}