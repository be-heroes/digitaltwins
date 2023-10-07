namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateShadow : IState
    {
        int PeerVersion { get; init; }
    }
}
