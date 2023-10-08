namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential synchronizer that synchronizes changes to a given differential T.
    /// </summary>
    /// <typeparam name="TDiff">The type of object being synchronized.</typeparam>
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
        /// Represents a differential synchronizer that synchronizes changes to a given differential T.
        /// </summary>
        /// <typeparam name="TDiff">The type of differential being synchronized.</typeparam>
        public DifferentialSynchronizer(TDiff current, ISequencer sequencer, IDifferentialQueue? differentialQueue = default!)
        {
            _current = current ?? throw new ArgumentNullException(nameof(current));
            _sequencer = sequencer ?? throw new ArgumentNullException(nameof(sequencer));
            _differentialQueue = differentialQueue ?? new DifferentialQueue();

            //Assign the next sequence number to the current version.
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
        /// Gets the differentials from the differential queue as an immutable queue.
        /// </summary>
        /// <returns>An immutable queue of differentials.</returns>
        public ValueTask<IEnumerator<IDifferential>> GetPendingDifferentials()
        {
            return ValueTask.FromResult(_differentialQueue.GetEnumerator());
        }

        /// <summary>
        /// Applies the specified differential to the current differential.
        /// </summary>
        /// <param name="differential">The differential to apply.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        public abstract ValueTask ApplyDifferential(IDifferential differential);
    }
}