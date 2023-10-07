using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateTests
    {
        [Fact]
        public void CanBeCreated()
        {
            // Arrange
            var data = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("key", "value") };
            var previousData = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("key", "previousValue") };
            var version = 1;

            // Act
            var state = new State(data, version, previousData);

            // Assert
            Assert.NotNull(state);
            Assert.Equal(data, state.Data);
            Assert.NotNull(state.PreviousData);
            Assert.Equal(previousData, state.PreviousData);
            Assert.Equal(version, state.Version);
        }
    }
}