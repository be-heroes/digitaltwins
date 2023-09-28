namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IState : IDisposable, IAsyncDisposable
    {
        IEnumerable<KeyValuePair<string, string>> Attributes { get; init; }

        IEnumerable<KeyValuePair<string, string>> PreviousAttributes { get; }

        IEnumerable<KeyValuePair<string, string>> Labels { get; init; }

        IEnumerable<KeyValuePair<string, string>> PreviousLabels { get; }

        int Version { get; init; }
    }
}
