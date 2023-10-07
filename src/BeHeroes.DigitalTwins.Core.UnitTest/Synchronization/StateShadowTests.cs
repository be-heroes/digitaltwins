using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateShadowTests
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
            var peerVersion = 2;

            // Act
            var stateShadow = new StateShadow(data, previousData, metadata, previousMetadata, version, peerVersion);

            // Assert
            Assert.NotNull(stateShadow);
            Assert.Equal(data, stateShadow.Data);
            Assert.Equal(previousData, stateShadow.PreviousData);
            Assert.Equal(metadata, stateShadow.Metadata);
            Assert.Equal(previousMetadata, stateShadow.PreviousMetadata);
            Assert.Equal(version, stateShadow.Version);
            Assert.Equal(peerVersion, stateShadow.PeerVersion);
        }
    }
}