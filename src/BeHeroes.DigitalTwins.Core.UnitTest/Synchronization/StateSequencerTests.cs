using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateSequencerTests
    {
        [Fact]
        public void CurrentSeed_ReturnsInitialSeed()
        {
            // Arrange
            var sequencer = new StateSequencer();

            // Act
            var seed = sequencer.CurrentSeed();

            // Assert
            Assert.Equal(0ul, seed);
        }

        [Fact]
        public void NextSeed_ReturnsIncrementedSeed()
        {
            // Arrange
            var sequencer = new StateSequencer();

            // Act
            var seed1 = sequencer.NextSeed();
            var seed2 = sequencer.NextSeed();

            // Assert
            Assert.Equal(1ul, seed1);
            Assert.Equal(2ul, seed2);
        }

        [Fact]
        public void Reset_ResetsSeedToZero()
        {
            // Arrange
            var sequencer = new StateSequencer();
            sequencer.NextSeed();

            // Act
            sequencer.Reset();

            // Assert
            Assert.Equal(0ul, sequencer.CurrentSeed());
        }
    }
}