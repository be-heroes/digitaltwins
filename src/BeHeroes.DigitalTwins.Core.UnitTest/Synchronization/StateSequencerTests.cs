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
            var current1 = sequencer.Current();
            var next1 = (long)sequencer.Next();
            var current2 = (long?)sequencer.Current();

            // Assert
            Assert.Null(current1);
            Assert.True(next1 == default!);
            Assert.NotNull(current2);
            Assert.True(current2.Value == default!);
        }

        [Fact]
        public void NextSeed_ReturnsIncrementedSeed()
        {
            // Arrange
            var sequencer = new StateSequencer();

            // Act
            var current1 = sequencer.Current();
            var next1 = (long)sequencer.Next();
            var current2 = (long?)sequencer.Current();
            var next2 = (long)sequencer.Next();

            // Assert
            Assert.Null(current1);
            Assert.True(next1 == default!);
            Assert.NotNull(current2);
            Assert.True(current2.Value == default!);
            Assert.True(next2 != default!);
            Assert.True(next1 < next2);
        }

        [Fact]
        public void Reset_ResetsSeedToZero()
        {
            // Arrange
            var sequencer = new StateSequencer();
            sequencer.Next();

            // Act
            sequencer.Reset();

            // Assert
            Assert.Null(sequencer.Current());
            Assert.NotNull(sequencer.Next());
            Assert.NotNull(sequencer.Current());
        }
    }
}