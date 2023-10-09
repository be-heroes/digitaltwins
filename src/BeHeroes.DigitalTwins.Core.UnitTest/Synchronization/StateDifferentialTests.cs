using BeHeroes.DigitalTwins.Core.Synchronization;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateDifferentialTests
    {
        [Fact]
        public void CanBeCreated()
        {
            // Arrange
            var data = new List<KeyValuePair<string, object>> { new("key", "value") };
            var previousData = new List<KeyValuePair<string, object>> { new("key", "previousValue") };
            var version = 1ul;

            // Act
            var diff = new StateDifferential(data, version, previousData);

            // Assert
            Assert.NotNull(diff);
            Assert.Equal(data, diff.GetData<object>().Result);
            Assert.NotNull(diff.GetPreviousData<object>().Result);
            Assert.Equal(previousData, diff.GetPreviousData<object>().Result);
            Assert.Equal(version, diff.Version);
        }
    }
}