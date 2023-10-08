namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state in the synchronization process.
    /// </summary>
    public interface IState: IDifferential 
    {
        /// <summary>
        /// Handles the state of the context.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        ValueTask Handle(IStateContext context);

        /// <summary>
        /// Gets the data of the state object as type TData.
        /// </summary>
        ValueTask<TData> GetData<TData>() where TData : class;

        /// <summary>
        /// Gets the data of the state object before the last state transition as type TData.
        /// </summary>
        ValueTask<TData?> GetPreviousData<TData>() where TData : class;
    }
}
