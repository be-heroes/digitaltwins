namespace BeHeroes.DigitalTwins.Core.State
{
    public interface IStateSequencer
    {
        ulong CurrentSeed();
        
        ulong NextSeed();
    }
}
