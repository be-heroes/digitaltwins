using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.DigitalTwins.Core
{
    /// <summary>
    /// Represents the status of an actor.
    /// </summary>
    public class ActorStatus : EntityEnumeration
    {
        /// <summary>
        /// Represents an available actor status.
        /// </summary>
        public static ActorStatus Available = new ActorStatus(1, nameof(Available).ToLowerInvariant());

        /// <summary>
        /// Represents an unavailable actor status.
        /// </summary>
        public static ActorStatus Unavailable = new ActorStatus(2, nameof(Unavailable).ToLowerInvariant());

        /// <summary>
        /// Represents an unknown actor status.
        /// </summary>
        public static ActorStatus Unknown = new ActorStatus(4, nameof(Unknown).ToLowerInvariant());

        /// <summary>
        /// Protected constructor used by EF Core.
        /// </summary>
        protected ActorStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStatus"/> EntityEnumerator with the specified id and name.
        /// </summary>
        /// <param name="id">The id of the actor status.</param>
        /// <param name="name">The name of the actor status.</param>
        public ActorStatus(int id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// Returns a list of all available actor statuses.
        /// </summary>
        public static IEnumerable<ActorStatus> List() => new[] { Available, Unavailable, Unknown };

        /// <summary>
        /// Returns the actor status with the specified name.
        /// </summary>
        /// <param name="name">The name of the actor status to retrieve.</param>
        /// <returns>The actor status with the specified name.</returns>
        /// <exception cref="ArgumentException">Thrown when no actor status with the specified name is found.</exception>
        public static ActorStatus FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException(nameof(state));
            }

            return state;
        }

        /// <summary>
        /// Returns the actor status with the specified id.
        /// </summary>
        /// <param name="id">The id of the actor status to retrieve.</param>
        /// <returns>The actor status with the specified id.</returns>
        /// <exception cref="ArgumentException">Thrown when no actor status with the specified ID is found.</exception>
        public static ActorStatus From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException(nameof(state));
            }

            return state;
        }
    }
}
