using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Entities;
using BeHeroes.CodeOps.Abstractions.Identity.Did;
using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.Replicas
{
    /// <summary>
    /// Represents a base class for all replicas in the system.
    /// </summary>
    public abstract class Replica : ValueObject, IDisposable, IAsyncDisposable, IReplica
    {
        /// <summary>
        /// The context used to track the state of the replica.
        /// </summary>
        protected readonly IStateContext _context;

        /// <summary>
        /// The decentralized identifier of the replica.
        /// </summary>
        protected readonly DecentralizedIdentifier _identifier;

        /// <summary>
        /// Gets the type of actor associated with this replica.
        /// </summary>
        public ActorType ActorType => ActorType.System;

        /// <summary>
        /// Gets or sets the decentralized identifier of the replica.
        /// </summary>
        public DecentralizedIdentifier Identifier => _identifier;

        /// <summary>
        /// Gets or sets the security key used to authenticate the replica.
        /// </summary>
        public IKey? SecurityKey { get; init; } = default!;

        /// <summary>
        /// Gets or sets the status of the actor associated with this replica.
        /// </summary>
        public ActorStatus ActorStatus { get; init; } = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica"/> class.
        /// </summary>
        protected Replica(IStateContext context, DecentralizedIdentifier identifier)
        {
            _context = context;
            _identifier = identifier;
        }
        
        /// <summary>
        /// Gets the resource principal for the replica.
        /// </summary>
        /// <returns>A key-value pair representing the resource principal, or null if the replica does not have a resource principal.</returns>
        public abstract KeyValuePair<string, string>? GetResourcePrincipal();

        /// <summary>
        /// Handles the given replica request and returns a replica response.
        /// </summary>
        /// <param name="request">The replica request to handle.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the replica response.</returns>
        public abstract Task<IReplicaResponse> Handle(IReplicaRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Releases the unmanaged resources used by the Replica and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected abstract void Dispose(bool disposing);

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources asynchronously.
        /// </summary>
        public ValueTask DisposeAsync()
        {
            Dispose();

            return ValueTask.CompletedTask;
        }
    }
}