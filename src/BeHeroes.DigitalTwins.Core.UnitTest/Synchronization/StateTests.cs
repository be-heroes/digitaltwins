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
            var metadata = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("key", "metadataValue") };
            var previousMetadata = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("key", "previousMetadataValue") };
            var version = 1;

            // Act
            var state = new State(data, previousData, metadata, previousMetadata, version);

            // Assert
            Assert.NotNull(state);
            Assert.Equal(data, state.Data);
            Assert.Equal(previousData, state.PreviousData);
            Assert.Equal(metadata, state.Metadata);
            Assert.Equal(previousMetadata, state.PreviousMetadata);
            Assert.Equal(version, state.Version);
        }
    }
}