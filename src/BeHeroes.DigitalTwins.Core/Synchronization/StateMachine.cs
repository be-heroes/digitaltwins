
namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state machine that synchronizes differential updates of a state.
    /// </summary>
    public class StateMachine : DifferentialSynchronizer<IState>, IStateMachine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachine"/> class with the specified current state, shadow state, and differential queue.
        /// </summary>
        /// <param name="current">The current state.</param>
        /// <param name="shadow">The shadow state.</param>
        /// <param name="differentialQueue">The differential queue.</param>
        public StateMachine(IState current, IDifferentialQueue? differentialQueue) : base(current, differentialQueue)
        {
            _shadow = new StateShadow(current.GetData(), current.Version, current.GetPreviousData()) {
                PeerVersion = current.Version
            };
        }

        /// <summary>
        /// Applies the given differential to the state machine.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        public override ValueTask ApplyDifferential(IDifferential differential)
        {
            throw new NotImplementedException();
        }
    }
}
