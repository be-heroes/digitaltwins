using System.Collections.Immutable;
using BeHeroes.CodeOps.Abstractions.Synchronization.Differential;
using BeHeroes.DigitalTwins.Core.Synchronization;
using Moq;
using SynchronizationContext = BeHeroes.DigitalTwins.Core.Synchronization.SynchronizationContext;

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
        
        [Fact]
        public async Task CanHandleSynchronizationContextWithoutEdits()
        {
            // Arrange
            var currentDifferential = new StateDifferential("data", 10);
            var context = new Mock<ISynchronizationContext>();
            
            context.Setup(x => x.GetDifferentialEdits()).Returns(ImmutableQueue<IDifferential>.Empty.AsEnumerable().GetEnumerator());

            // Act
            await currentDifferential.Handle(context.Object);

            // Assert
            Assert.Equal(currentDifferential.Version, 10);
            Assert.Equal(await currentDifferential.GetData<string>(), "data");
        }
        
        [Fact]
        public async Task CanHandleSynchronizationContextWithEdits()
        {
            // Arrange
            var currentDifferential = new StateDifferential("data", 10);
            var versionedDifferential = new StateDifferential("new data", 20);
            var differentialQueue = new DifferentialQueue(ImmutableQueue<IDifferential>.Empty.Enqueue(versionedDifferential));
            var context = new SynchronizationContext(differentialQueue: differentialQueue);

            // Act
            await currentDifferential.Handle(context);

            // Assert
            Assert.Equal(currentDifferential.Version, versionedDifferential.Version);
            Assert.Equal(await currentDifferential.GetData<object>(), await versionedDifferential.GetData<object>());
            Assert.Equal(await currentDifferential.GetPreviousData<string>(), "data");
        }
        
        [Fact]
        public async Task CanHandleSynchronizationContextWithStallEdits()
        {
            // Arrange
            var currentDifferential = new StateDifferential("data", 10);
            var versionedDifferential = new StateDifferential("old data", 5);
            var differentialQueue = new DifferentialQueue(ImmutableQueue<IDifferential>.Empty.Enqueue(versionedDifferential));
            var context = new SynchronizationContext(differentialQueue: differentialQueue);

            // Act
            await currentDifferential.Handle(context);

            // Assert
            Assert.Equal(currentDifferential.Version, 10);
            Assert.Equal(await currentDifferential.GetData<string>(), "data");
            Assert.Equal(await currentDifferential.GetPreviousData<object>(), null);
            Assert.NotEqual(currentDifferential.Version, versionedDifferential.Version);
            Assert.NotEqual(await currentDifferential.GetData<object>(), await versionedDifferential.GetData<object>());
        }
    }
}