namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential synchronizer that synchronizes changes to a given differential.
    /// </summary>
    /// <typeparam name="TDiff">The type of differential being handle by the synchronizer.</typeparam>
    public abstract class DifferentialSynchronizer<TDiff> : IDifferentialSynchronizer<TDiff> where TDiff : class, IDifferential
    {
        /// <summary>
        /// The queue used to store differential updates to be synchronized.
        /// </summary>
        protected IDifferentialQueue _differentialQueue = default!;
                
        /// <summary>
        /// The sequencer used to generate sequence numbers for differential updates.
        /// </summary>
        protected readonly ISequencer _sequencer = default!;

        /// <summary>
        /// The current differential being synchronized.
        /// </summary>
        protected TDiff _current = default!;

        /// <summary>
        /// The shadow copy of the current differential being synchronized.
        /// </summary>
        protected TDiff _shadow = default!;

        /// <summary>
        /// Represents a differential synchronizer that synchronizes changes to a given differential.
        /// </summary>
        /// <typeparam name="TDiff">The type of differential being handle by the synchronizer.</typeparam>
        public DifferentialSynchronizer(TDiff current, ISequencer sequencer, IDifferentialQueue? differentialQueue = default!)
        {
            //Assign the current differential and sequencer.
            _current = current ?? throw new ArgumentNullException(nameof(current));
            _sequencer = sequencer ?? throw new ArgumentNullException(nameof(sequencer));
            _differentialQueue = differentialQueue ?? new DifferentialQueue();

            //Assign the first sequence number (zero) to the current version.
            _current.Version = _sequencer.Next();

            //Synchronize the shadow state.
            _shadow = _current;
        }

        /// <summary>
        /// Gets the current differential of the synchronizer.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TDiff}"/> representing the asynchronous operation.</returns>
        public ValueTask<TDiff> GetCurrentDifferential()
        {
            return ValueTask.FromResult(_current);
        }

        /// <summary>
        /// Returns an asynchronous operation that yields an enumerator over the pending differentials in the queue.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TResult}"/> representing the asynchronous operation that yields an enumerator over the pending differentials in the queue.</returns>
        public ValueTask<IEnumerator<IDifferential>> GetPendingDifferentials()
        {
            return ValueTask.FromResult(_differentialQueue.GetEnumerator());
        }

        /// <summary>
        /// Applies the specified differential to the differentials queue and initialies a state transition.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        public abstract ValueTask ApplyDifferential(IDifferential differential);
    }
}