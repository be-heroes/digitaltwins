using System.Collections;
using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in Synchronization namespace
    /// <summary>
    /// Represents a differential queue that tracks differential changes in a given context.
    /// </summary>
    public sealed class DifferentialQueue : IDifferentialQueue
    {
        /// <summary>
        /// An immutable queue of <see cref="IDifferential"/> instances to be applied in a given context.
        /// </summary>
        private readonly IImmutableQueue<IDifferential> _queue = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferentialQueue"/> class.
        /// </summary>
        /// <param name="queue">The immutable queue of differentials to initialize the queue with.</param>
        public DifferentialQueue(IImmutableQueue<IDifferential>? queue = default!)
        {
            _queue = queue ?? ImmutableQueue<IDifferential>.Empty;
        }

        /// <summary>
        /// Gets a value indicating whether the differential queue is empty.
        /// </summary>
        public bool IsEmpty => _queue.Count() == 0;

        /// <summary>
        /// Removes and returns the immutable queue at the beginning of the differential queue.
        /// </summary>
        /// <returns>The immutable queue at the beginning of the differential queue.</returns>
        public IImmutableQueue<IDifferential> Dequeue() => _queue.Dequeue();
        
        /// <summary>
        /// Adds an <see cref="IDifferential"/> to the end of the queue.
        /// </summary>
        /// <param name="diff">The <see cref="IDifferential"/> to add to the queue.</param>
        /// <returns>A new <see cref="IImmutableQueue{T}"/> with the added <see cref="IDifferential"/>.</returns>
        public IImmutableQueue<IDifferential> Enqueue(IDifferential diff) => _queue.Enqueue(diff);

        /// <summary>
        /// Returns the next differential edit in the queue without removing it.
        /// </summary>
        /// <returns>The next differential edit in the queue.</returns>
        public IDifferential Peek() => !IsEmpty ? _queue.Peek() : default!;

        /// <summary>
        /// Returns an enumerator that iterates through the differentials in the differential queue.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the unconfirmed edits in the differential queue.</returns>
        public IEnumerator<IDifferential> GetEnumerator() => _queue.GetEnumerator();

        /// <summary>
        /// Removes all differentials from the queue.
        /// </summary>
        /// <returns>An empty immutable queue of differentials.</returns>
        public IImmutableQueue<IDifferential> Clear() => _queue.Clear();

        /// <summary>
        /// Returns an enumerator that iterates through the differentials in the differential queue.
        /// </summary>
        /// <returns>An enumerator that iterates through the differentials in the differential queue.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}