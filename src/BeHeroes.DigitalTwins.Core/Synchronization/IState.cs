namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state object for a digital twin.
    /// </summary>
    public interface IState : IDifferential 
    {
        /// <summary>
        /// Handles state transitions for a given context.
        /// </summary>
        /// <param name="context">The context for the state transition.</param>
        ValueTask Handle(IStateContext context);

        /// <summary>
        /// Gets the data of the state object as type TData.
        /// </summary>
        ValueTask<TData> GetData<TData>() where TData : class;

        /// <summary>
        /// Gets the data of the state object prior to the last state transition typed as TData.
        /// </summary>
        ValueTask<TData?> GetPreviousData<TData>() where TData : class;
    }
}
