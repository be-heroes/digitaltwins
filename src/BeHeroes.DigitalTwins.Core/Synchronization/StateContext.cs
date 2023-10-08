
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
        public StateContext(IState current, IDifferentialQueue? differentialQueue = default!) : base(current, new StateSequencer(), differentialQueue)
        {
            SynchronizeStateShadow();
        }

        /// <summary>
        /// Applies the given differential to the current state.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        public override ValueTask ApplyDifferential(IDifferential differential)
        {
            //Updaet the local diff queue.
            _differentialQueue = new DifferentialQueue(_differentialQueue.Enqueue(differential));

            //Handle the state transition.
            _current.Handle(this);

            return ValueTask.CompletedTask;
        }

        /// <summary>
        /// Synchronizes the shadow state with the current state by creating a new StateShadow object instance.
        /// </summary>
        private void SynchronizeStateShadow() {            
            //Update the inherited shadow state field with an appropriate StateShadow object instance derived from the current state.
            _shadow = new StateShadow(_current.GetData<object>().Result, _current.Version, _current.GetPreviousData<object>().Result) {
                PeerVersion = _current.Version
            };
        }
    }
}
