using System.Collections.Immutable;

//TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a queue that tracks differential changes.
    /// </summary>
    public interface IDifferentialQueue : IImmutableQueue<IDifferential>
    {
    }
}
