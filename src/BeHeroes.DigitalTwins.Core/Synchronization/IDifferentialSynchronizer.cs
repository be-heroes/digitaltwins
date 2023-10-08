namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential synchronizer that can be used to synchronize objects in a distributed system.
    /// </summary>
    /// <typeparam name="TDiff">The type of object that is being synchronized.</typeparam>
    public interface IDifferentialSynchronizer<TDiff> where TDiff : class, IDifferential
    {
        /// <summary>
        /// Gets the current differential of the synchronizer.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TDiff}"/> representing the asynchronous operation, containing the current value of the synchronizer.</returns>
        ValueTask<TDiff> GetCurrentDifferential();
        
        /// <summary>
        /// Asynchronously retrieves an enumerator of differentials that represent the unconfirmed commits for the synchronizers current differential.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TResult}"/> that represents the asynchronous operation. The result of the task contains an enumerator of <see cref="IDifferential"/> objects.</returns>
        ValueTask<IEnumerator<IDifferential>> GetPendingDifferentials();

        /// <summary>
        /// Applies the specified differential to the differentials synchronizer.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        ValueTask ApplyDifferential(IDifferential differential);
    }
}   
