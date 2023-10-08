using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateTests
    {
        [Fact]
        public void CanBeCreated()
        {
            // Arrange
            var data = new List<KeyValuePair<string, object>> { new("key", "value") };
            var previousData = new List<KeyValuePair<string, object>> { new("key", "previousValue") };
            var version = 1ul;

            // Act
            var state = new State(data, version, previousData);

            // Assert
            Assert.NotNull(state);
            Assert.Equal(data, state.GetData<object>().Result);
            Assert.NotNull(state.GetPreviousData<object>().Result);
            Assert.Equal(previousData, state.GetPreviousData<object>().Result);
            Assert.Equal(version, state.Version);
        }
    }
}