using System.Collections;
using System.Collections.Immutable;

namespace BeHeroes.DigitalTwins.Core.State
{
    /// <summary>
    /// Represents a state tracker that keeps track of a collection of states.
    /// </summary>
    public sealed class StateTracker : IStateTracker
    {
        /// <summary>
        /// An immutable queue of <see cref="IState"/> objects representing the history of the state tracker.
        /// </summary>
        private readonly IImmutableQueue<IState> _states;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateTracker"/> class with the specified states and state sequencer.
        /// </summary>
        /// <param name="states">The immutable queue of states to initialize the state tracker with.</param>
        /// <param name="stateSequencer">The state sequencer to use for sequencing states.</param>
        public StateTracker(IImmutableQueue<IState> states, IStateSequencer stateSequencer)
        {
            _states = states;
            StateSequencer = stateSequencer;
        }

        /// <summary>
        /// Gets the state sequencer used to track the current state of the digital twin.
        /// </summary>
        public IStateSequencer StateSequencer { get; }

        /// <summary>
        /// Gets a value indicating whether the state tracker is empty.
        /// </summary>
        public bool IsEmpty => _states.Count() == 0;

        /// <summary>
        /// Removes and returns the element at the beginning of the queue of states.
        /// </summary>
        /// <returns>The element that is removed from the beginning of the queue of states.</returns>
        public IImmutableQueue<IState> Dequeue() => _states.Dequeue();

        /// <summary>
        /// Adds a new state to the end of the queue.
        /// </summary>
        /// <param name="state">The state to add to the queue.</param>
        /// <returns>A new immutable queue with the added state.</returns>
        public IImmutableQueue<IState> Enqueue(IState state) => _states.Enqueue(state);

        /// <summary>
        /// Returns the top element of the stack without removing it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public IState Peek() => _states.Peek();

        /// <summary>
        /// Returns an enumerator that iterates through the collection of states.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection of states.</returns>
        public IEnumerator<IState> GetEnumerator() => _states.GetEnumerator();

        /// <summary>
        /// Removes all states from the state tracker.
        /// </summary>
        /// <returns>An empty immutable queue of states.</returns>
        public IImmutableQueue<IState> Clear() => _states.Clear();

        /// <summary>
        /// Returns an enumerator that iterates through the collection of states.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection of states.</returns>
        IEnumerator IEnumerable.GetEnumerator() => _states.GetEnumerator();
    }
}