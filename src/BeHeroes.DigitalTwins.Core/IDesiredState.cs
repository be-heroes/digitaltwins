namespace BeHeroes.DigitalTwins.Core
{
    public interface IDesiredState : IState
    {
        IEnumerable<KeyValuePair<string, string>> Labels { get; }

        IEnumerable<KeyValuePair<string, string>> Properties { get; }
    }
}
