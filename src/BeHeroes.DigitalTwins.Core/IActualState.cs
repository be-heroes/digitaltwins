namespace BeHeroes.DigitalTwins.Core
{
    public interface IActualState : IDesiredState
    {
        DateTime Created { get; }

        DateTime LastUpdated { get; }
    }
}
