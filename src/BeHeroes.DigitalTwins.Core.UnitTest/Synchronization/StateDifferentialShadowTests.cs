using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateDifferentialShadowTests
    {
        [Fact]
        public void CanBeCreated()
        {
            // Arrange
            var data = new List<KeyValuePair<string, object>> { new("key", "value") };
            var previousData = new List<KeyValuePair<string, object>> { new("key", "previousValue") };
            var version = 1ul;
            var peerVersion = 2ul;

            // Act
            var stateShadow = new StateDifferentialShadow(data, version, peerVersion, previousData);

            // Assert
            Assert.NotNull(stateShadow);
            Assert.Equal(data, stateShadow.GetData<object>().Result);
            Assert.NotNull(stateShadow.GetPreviousData<object>().Result);
            Assert.Equal(previousData, stateShadow.GetPreviousData<object>().Result);
            Assert.Equal(version, stateShadow.Version);
            Assert.Equal(peerVersion, stateShadow.PeerVersion);
        }
    }
}