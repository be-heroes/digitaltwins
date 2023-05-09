namespace BeHeroes.DigitalTwins.Core
{
    public interface IState : IDisposable, IAsyncDisposable
    {
        string ApiVersion { get; }
    }
}
