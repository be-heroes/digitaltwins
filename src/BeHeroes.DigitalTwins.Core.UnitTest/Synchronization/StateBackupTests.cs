using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateBackupTests
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
            var stateBackup = new StateBackup(data, version, peerVersion, previousData);

            // Assert
            Assert.NotNull(stateBackup);
            Assert.Equal(data, stateBackup.Data);
            Assert.NotNull(stateBackup.PreviousData);
            Assert.Equal(previousData, stateBackup.PreviousData);
            Assert.Equal(version, stateBackup.Version);
            Assert.Equal(peerVersion, stateBackup.PeerVersion);
        }
    }
}