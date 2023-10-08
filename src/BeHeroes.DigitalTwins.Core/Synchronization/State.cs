
using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents the state of a digital twin.
    /// </summary>
    public class State : IState
    {
        /// <summary>
        /// The data object that is being synchronized.
        /// </summary>
        private readonly object _data;

        /// <summary>
        /// The previous data associated with the state.
        /// </summary>
        private readonly object? _previousData;

        /// <summary>
        /// The version number of the state.
        /// </summary>
        private readonly BigInteger _version;

        /// <summary>
        /// Gets the version of the state.
        /// </summary>
        public BigInteger Version => _version;

        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="data">The data object to be stored in the state.</param>
        /// <param name="version">The version number of the state.</param>
        /// <param name="previousData">The previous data object stored in the state, if any.</param>
        public State(object data, BigInteger version, object? previousData = default)
        {
            _version = version;
            _data = data;
            _previousData = previousData;
        }

        /// <summary>
        /// Gets the data associated with this state.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TResult}"/> representing the asynchronous operation.</returns>
        public ValueTask<object> GetData()
        {
            return ValueTask.FromResult(_data);
        }

        /// <summary>
        /// Gets the previous data associated with this state.
        /// </summary>
        /// <returns>A <see cref="ValueTask{TResult}"/> representing the asynchronous operation, containing the previous data associated with this state.</returns>
        public ValueTask<object?> GetPreviousData()
        {
            return ValueTask.FromResult(_previousData);
        }
    }
}