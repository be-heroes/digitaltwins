namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    /// <summary>
    /// Represents a state machine that tracks the current state, shadow state, and backup state.
    /// </summary>
    public sealed class StateMachine : IStateMachine
    {
        /// <summary>
        /// Gets the state tracker for the state machine.
        /// </summary>
        public IStateTracker StateTracker { get; }

        /// <summary>
        /// Gets the current state of the state machine.
        /// </summary>
        public IState State { get; }

        /// <summary>
        /// Gets the shadow of the current state.
        /// </summary>
        public IStateShadow StateShadow { get;}

        /// <summary>
        /// Gets the state backup object associated with this state machine.
        /// </summary>
        public IStateBackup StateBackup { get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachine"/> class with the specified state tracker, state, state shadow, and state backup.
        /// </summary>
        /// <param name="stateTracker">The state tracker to use.</param>
        /// <param name="state">The initial state of the state machine.</param>
        /// <param name="stateShadow">The state shadow to use.</param>
        /// <param name="stateBackup">The state backup to use.</param>
        public StateMachine(IStateTracker stateTracker, IState state, IStateShadow stateShadow, IStateBackup stateBackup)
        {
            StateTracker = stateTracker;
            State = state;
            StateShadow = stateShadow;
            StateBackup = stateBackup;
        }
    }
}