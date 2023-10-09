using System.Collections.Immutable;

//TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents an immutable queue of differential elements.
    /// </summary>
    public interface IDifferentialQueue : IImmutableQueue<IDifferential>
    {
    }
}
