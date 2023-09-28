namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IShadowState : IState
    {
        bool IsBackup { get; init; }

        int PeerVersion { get; init; }
    }
}
