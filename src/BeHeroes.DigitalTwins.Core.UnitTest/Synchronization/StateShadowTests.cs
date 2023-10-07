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
            var version = 1;
            var peerVersion = 2;

            // Act
            var stateShadow = new StateShadow(data, version, peerVersion, previousData);

            // Assert
            Assert.NotNull(stateShadow);
            Assert.Equal(data, stateShadow.Data);
            Assert.NotNull(stateShadow.PreviousData);
            Assert.Equal(previousData, stateShadow.PreviousData);
            Assert.Equal(version, stateShadow.Version);
            Assert.Equal(peerVersion, stateShadow.PeerVersion);
        }
    }
}