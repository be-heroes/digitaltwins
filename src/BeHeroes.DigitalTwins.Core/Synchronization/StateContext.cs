
namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a context for synchronizing the state of a digital twin.
    /// </summary>
    public class StateContext : DifferentialSynchronizer<IState>, IStateContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateContext"/> class with the specified current state and differential queue.
        /// </summary>
        /// <param name="current">The current state.</param>
        /// <param name="differentialQueue">The differential queue.</param>
        public StateContext(IState current, IDifferentialQueue? differentialQueue) : base(current, differentialQueue)
        {
            _shadow = new StateShadow(current.GetData(), current.Version, current.GetPreviousData()) {
                PeerVersion = current.Version
            };
        }

        /// <summary>
        /// Applies the given differential to the current state.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        public override ValueTask ApplyDifferential(IDifferential differential)
        {
            throw new NotImplementedException();
        }
    }
}
