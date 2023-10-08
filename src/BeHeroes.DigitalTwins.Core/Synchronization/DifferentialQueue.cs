using System.Collections;
using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential queue that tracks unconfirmed changes to a objects state.
    /// </summary>
    public sealed class DifferentialQueue : IDifferentialQueue
    {
        /// <summary>
        /// An immutable queue of unconfirmed <see cref="IDifferential"/> instances to be applied to a state object.
        /// </summary>
        private readonly IImmutableQueue<IDifferential> _unconfirmedEdits;
                
        /// <summary>
        /// The sequencer used to generate sequence numbers for differential updates.
        /// </summary>
        private readonly ISequencer _sequencer = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferentialQueue"/> class.
        /// </summary>
        /// <param name="sequencer">The sequencer to use for generating sequence numbers.</param>
        public DifferentialQueue(ISequencer? sequencer = default!, IImmutableQueue<IDifferential>? unconfirmedEdits = default!)
        {
            _sequencer = sequencer ?? new Sequencer();
            _unconfirmedEdits = unconfirmedEdits ?? ImmutableQueue<IDifferential>.Empty;
        }

        /// <summary>
        /// Gets a value indicating whether the differential queue is empty.
        /// </summary>
        public bool IsEmpty => _unconfirmedEdits.Count() == 0;

        /// TODO: Check to see if dequeue operation should update sequencer
        /// <summary>
        /// Removes and returns the immutable queue at the beginning of the differential queue.
        /// </summary>
        /// <returns>The immutable queue at the beginning of the differential queue.</returns>
        public IImmutableQueue<IDifferential> Dequeue() => _unconfirmedEdits.Dequeue();
        
        /// TODO: Check to see if enqueue operation should update sequencer
        /// <summary>
        /// Adds an <see cref="IDifferential"/> to the end of the queue.
        /// </summary>
        /// <param name="state">The <see cref="IDifferential"/> to add to the queue.</param>
        /// <returns>A new <see cref="IImmutableQueue{T}"/> with the added <see cref="IDifferential"/>.</returns>
        public IImmutableQueue<IDifferential> Enqueue(IDifferential state) => _unconfirmedEdits.Enqueue(state);

        /// <summary>
        /// Returns the next differential edit in the queue without removing it.
        /// </summary>
        /// <returns>The next differential edit in the queue.</returns>
        public IDifferential Peek() => !IsEmpty ? _unconfirmedEdits.Peek() : default!;

        /// <summary>
        /// Returns an enumerator that iterates through the unconfirmed edits in the differential queue.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the unconfirmed edits in the differential queue.</returns>
        public IEnumerator<IDifferential> GetEnumerator() => _unconfirmedEdits.GetEnumerator();

        /// <summary>
        /// Removes all differentials from the queue and resets the sequencer.
        /// </summary>
        /// <returns>An empty immutable queue of differentials.</returns>
        public IImmutableQueue<IDifferential> Clear() 
        {
             _sequencer.Reset();
             
             return _unconfirmedEdits.Clear();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the unconfirmed edits.
        /// </summary>
        /// <returns>An enumerator that iterates through the unconfirmed edits.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Returns a <see cref="ValueTask"/> that represents the asynchronous operation of getting the sequencer.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/> that represents the asynchronous operation of getting the sequencer.</returns>
        public ISequencer GetSequencer()
        {
            return _sequencer;
        }
    }
}