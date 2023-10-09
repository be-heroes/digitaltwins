using BeHeroes.CodeOps.Abstractions.Synchronization.Differential;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a synchronization context for a given state differential.
    /// </summary>
    public class SynchronizationContext : DifferentialSynchronizer<IStateDifferential>, ISynchronizationContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizationContext"/> class with the specified current state and differential queue.
        /// </summary>
        /// <param name="current">The current state.</param>
        /// <param name="differentialQueue">The differential queue.</param>
        public SynchronizationContext(IStateDifferential current, IDifferentialQueue? differentialQueue = default!) : base(current, new StateSequencer(), differentialQueue)
        {
            // Advance the sequencer to match the current differential version.
            while(_sequencer.Next() < _current.Version) { 
                // Do nothing.
            }

            // Synchronize the shadow state from the current state.
            SynchronizeShadow();
        }

        /// <summary>
        /// Applies the given differential to the current state.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        public async override ValueTask ApplyDifferential(IDifferential differential)
        {
            // Check to see if the differential is stall.
            var peekedElement = _differentialQueue.Peek();

            if(peekedElement != null && differential.Version <= peekedElement.Version){
                throw new ArgumentException("The differential is stall.", nameof(differential));
            }

            // Check to see if the differential is in sequence.
            if(differential.Version <= _sequencer.Current())            
            {
                throw new ArgumentException("The differential is out of sequence.", nameof(differential));
            }

            // Advance the sequencer to match the applied differential version.
            while(_sequencer.Current() < differential.Version) { 
                _sequencer.Next();
            }

            // Update the local differential queue.
            _differentialQueue = new DifferentialQueue(_differentialQueue.Enqueue(differential));

            // Handle the state transition of the current differential.
            await _current.Handle(this);

            // Synchronize the shadow with the patched differential.
            SynchronizeShadow();
            
            // Clear the local differential queue.
            _differentialQueue = new DifferentialQueue(_differentialQueue.Clear());
        }

        /// <summary>
        /// Synchronizes the shadow of the current state differential by creating and assigning a new StateDifferentialShadow instance.
        /// </summary>
        private void SynchronizeShadow() {            
            _shadow = new StateDifferentialShadow(_current.GetData<object>(), _current.Version, _current.Version, _current.GetPreviousData<object>());
        }
    }
}
