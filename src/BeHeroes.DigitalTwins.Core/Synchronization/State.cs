
using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state object that contains data to be synchronized.
    /// </summary>
    public class State : IState
    {
        /// <summary>
        /// The data object that is being synchronized.
        /// </summary>
        protected readonly object _data;

        /// <summary>
        /// The previous data associated with the state.
        /// </summary>
        protected readonly object? _previousData;

        /// <summary>
        /// The version number of the state.
        /// </summary>
        protected BigInteger _version;

        /// <summary>
        /// Gets the version of the state.
        /// </summary>
        public BigInteger Version { get => _version; set => _version = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="data">The data object to be stored in the state.</param>
        /// <param name="version">The version number of the state.</param>
        /// <param name="previousData">The previous data object stored in the state, if any.</param>
        public State(object data, BigInteger version, object? previousData = default)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
            _version = version;
            _previousData = previousData;
        }

        /// <summary>
        /// Handles the current state of the synchronization process.
        /// </summary>
        /// <param name="context">The context of the current state.</param>
        public virtual ValueTask Handle(IStateContext context)
        {
            throw new NotImplementedException("Finish this method.");
        }

        /// <summary>
        /// Gets the data stored in this state object.
        /// </summary>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation, containing the data stored in this state object.</returns>
        public ValueTask<TData> GetData<TData>() where TData : class
        {
            if (_data is TData data)
            {
                return ValueTask.FromResult(data);
            }

            throw new InvalidCastException($"Cannot cast data of type {_data.GetType().Name} to type {typeof(TData).Name}.");
        }

        /// <summary>
        /// Gets the previous data that was stored in this state object.
        /// </summary>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation. The result of the task contains the previous data that was stored in this state object.</returns>
        public ValueTask<TData?> GetPreviousData<TData>() where TData : class
        {
            if(_previousData != null && _previousData is not TData)
            {
                throw new InvalidCastException($"Cannot cast data of type {_previousData.GetType().Name} to type {typeof(TData).Name}.");
            }

            return ValueTask.FromResult(_previousData as TData);
        }
    }
}