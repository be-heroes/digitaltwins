using System.Collections.Immutable;

//TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a queue of differentials that can be used to track changes to an object.
    /// </summary>
    public interface IDifferentialQueue : IImmutableQueue<IDifferential>
    {
    }
}
