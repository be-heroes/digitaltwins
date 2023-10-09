using System.Numerics;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state differential used to manage the state of a replica.
    /// </summary>
    public class StateDifferential : IStateDifferential
    {
        /// <summary>
        /// The data object that is being synchronized by the state differential.
        /// </summary>
        protected readonly object _data;

        /// <summary>
        /// The previous data object associated with the state differential.
        /// </summary>
        protected readonly object? _previousData;

        /// <summary>
        /// The version number of the state differential.
        /// </summary>
        protected readonly BigInteger _version;

        /// <summary>
        /// Gets the version of the state differential.
        /// </summary>
        public BigInteger Version { get => _version; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateDifferential"/> class.
        /// </summary>
        /// <param name="data">The data object to be stored in the state differential.</param>
        /// <param name="version">The version number of the state differential.</param>
        /// <param name="previousData">The previous data object stored in the state differential, if any.</param>
        public StateDifferential(object data, BigInteger version, object? previousData = default)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
            _version = version;
            _previousData = previousData;
        }

        /// <summary>
        /// Handles state differential transitions for a given context.
        /// </summary>
        /// <param name="context">The synchronization context for the state differential transition.</param>
        public virtual async ValueTask Handle(ISynchronizationContext context)
        {
            // Check to see that the context version matches the state differential version.
            var contextVersion = (await context.GetCurrentDifferential()).Version;

            if(contextVersion != _version)
            {
                throw new ArgumentException($"The context version ({contextVersion}) does not match the state differential version ({_version}).", nameof(context));
            }

            // Get the pending differentials to use for the state transition.
            var unconfirmedDifferentials = await context.GetPendingDifferentials();

            while(unconfirmedDifferentials.MoveNext())
            {
                // Get the current differential in the enumerator.
                var differential = unconfirmedDifferentials.Current;

                // TODO: Implement state differential transition logic.
            }
        }

        /// <summary>
        /// Gets the data stored in this state differential.
        /// </summary>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation to fetch the data stored in this state differential.</returns>
        public ValueTask<TData> GetData<TData>() where TData : class
        {
            if (_data is TData data)
            {
                return ValueTask.FromResult(data);
            }

            throw new InvalidCastException($"Cannot cast data of type {_data.GetType().Name} to type {typeof(TData).Name}.");
        }

        /// <summary>
        /// Gets the previous data that was stored in this state differential.
        /// </summary>
        /// <returns>A <see cref="ValueTask{T}"/> representing the asynchronous operation to fetch the previous data that was stored in this state differential prior to a state transition.</returns>
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