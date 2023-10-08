using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class SequencerTests
    {
        [Fact]
        public void CurrentSeed_ReturnsInitialSeed()
        {
            // Arrange
            var sequencer = new Sequencer();

            // Act            
            var current1 = sequencer.Current();
            var next1 =  sequencer.Next();
            var current2 = sequencer.Current();

            // Assert
            Assert.Null(current1);
            Assert.True(next1 != default!);
            Assert.NotNull(current2);
            Assert.True(current2.Value != default!);
        }

        [Fact]
        public void NextSeed_ReturnsIncrementedSeed()
        {
            // Arrange
            var sequencer = new Sequencer();

            // Act
            var current1 = sequencer.Current();
            var next1 = sequencer.Next();
            var current2 = sequencer.Current();
            var next2 = sequencer.Next();

            // Assert
            Assert.Null(current1);
            Assert.True(next1 != default!);
            Assert.NotNull(current2);
            Assert.True(current2.Value != default!);
            Assert.True(next2 != default!);
            Assert.True(next1 < next2);
            Assert.Equal(next1, current2);
        }

        [Fact]
        public void Reset_ResetsSeedToZero()
        {
            // Arrange
            var sequencer = new Sequencer();
            sequencer.Next();

            // Act
            sequencer.Reset();

            // Assert
            Assert.Null(sequencer.Current());
            Assert.True(sequencer.Next() != default!);
            Assert.True(sequencer.Current() != default!);
        }
    }
}