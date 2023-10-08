
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
        public async override ValueTask ApplyDifferential(IDifferential differential)
        {
            //Assign the next sequence number to the applied differential.
            differential.Version = _sequencer.Next();

            //Updaet the local differential queue.
            _differentialQueue = new DifferentialQueue(_differentialQueue.Enqueue(differential));

            //Handle the state transition of the current differential.
            await _current.Handle(this);

            //Synchronize the shadow state from the patched differential.
            SynchronizeStateShadow();
        }

        /// <summary>
        /// Synchronizes the shadow state with the current state by creating a new StateShadow object instance.
        /// </summary>
        private void SynchronizeStateShadow() {            
            _shadow = new StateShadow(_current.GetData<object>(), _current.Version, _current.GetPreviousData<object>()) {
                PeerVersion = _current.Version
            };
        }
    }
}
