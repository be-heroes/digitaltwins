namespace BeHeroes.DigitalTwins.Core
{
    /// <summary>
    /// Represents the type of actor that interacts with the system.
    /// </summary>
    [Flags]
    public enum ActorType
    {
        /// <summary>
        /// Represents an actor type of none.
        /// </summary>
        None = 0,
        /// <summary>
        /// Represents a user actor type.
        /// </summary>
        User = 1,
        /// <summary>
        /// Represents a system actor.
        /// </summary>
        System = 2,
        /// <summary>
        /// Represents an external actor type.
        /// </summary>
        External = 4
    }
}
