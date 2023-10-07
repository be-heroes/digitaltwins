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
            var pending1 = sequencer.PendingSeed();
            var seed1 = sequencer.NextSeed();
            var pending2 = sequencer.PendingSeed();

            // Assert
            Assert.Null(pending1);
            Assert.Equal(0ul, seed1);
            Assert.Equal(0ul, pending2);
        }

        [Fact]
        public void NextSeed_ReturnsIncrementedSeed()
        {
            // Arrange
            var sequencer = new StateSequencer();

            // Act
            var pending1 = sequencer.PendingSeed();
            var seed1 = sequencer.NextSeed();
            var pending2 = sequencer.PendingSeed();
            var seed2 = sequencer.NextSeed();
            var pending3 = sequencer.PendingSeed();

            // Assert
            Assert.Null(pending1);
            Assert.Equal(0ul, seed1);
            Assert.Equal(0ul, pending2);
            Assert.Equal(1ul, seed2);
            Assert.Equal(1ul, pending3);
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
            Assert.Null(sequencer.PendingSeed());
            Assert.Equal(0ul, sequencer.NextSeed());
            Assert.Equal(0ul, sequencer.PendingSeed());
        }
    }
}