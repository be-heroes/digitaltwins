namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents an object that can calculate the difference between two versions.
    /// </summary>
    public interface IDifferential
    {
        /// <summary>
        /// Gets the version of the differential.
        /// </summary>
        ulong Version { get; }        
    }
}
