namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateSequencer
    {
        ulong Current();
        
        ulong Next();
    }
}
