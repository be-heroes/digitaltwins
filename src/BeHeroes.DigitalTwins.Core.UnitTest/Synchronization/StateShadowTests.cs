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
            var version = 1ul;
            var peerVersion = 2ul;

            // Act
            var stateShadow = new StateShadow(data, version, previousData)
            {
                PeerVersion = peerVersion
            };

            // Assert
            Assert.NotNull(stateShadow);
            Assert.Equal(data, stateShadow.GetData().Result);
            Assert.NotNull(stateShadow.GetPreviousData().Result);
            Assert.Equal(previousData, stateShadow.GetPreviousData().Result);
            Assert.Equal(version, stateShadow.Version);
            Assert.Equal(peerVersion, stateShadow.PeerVersion);
        }
    }
}