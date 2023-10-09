using BeHeroes.CodeOps.Abstractions.Synchronization.Differential;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state differential for a digital twin.
    /// </summary>
    public interface IStateDifferential  : IDifferential 
    {
        /// <summary>
        /// Handles state differential transitions for a given context.
        /// </summary>
        /// <param name="context">The synchrnozation context used in the state differential transition.</param>
        ValueTask Handle(ISynchronizationContext context);

        /// <summary>
        /// Gets the data contained in the state differential, typed as TData.
        /// </summary>
        ValueTask<TData> GetData<TData>() where TData : class;

        /// <summary>
        /// Gets the data contained in state differential prior to the last state transition, typed as TData.
        /// </summary>
        ValueTask<TData?> GetPreviousData<TData>() where TData : class;
    }
}
