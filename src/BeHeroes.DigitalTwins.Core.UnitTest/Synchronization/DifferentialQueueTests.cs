using BeHeroes.DigitalTwins.Core.Synchronization;
using Moq;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class DifferentialQueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var stateTracker = new DifferentialQueue();

            // Act
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object);

            // Assert
            Assert.Equal(2, newQueue.Count());
            Assert.Equal(state1.Object, newQueue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var stateTracker = new DifferentialQueue();
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object);

            // Act
            var dequeuedQueue = newQueue.Dequeue();

            // Assert
            Assert.Equal(1, dequeuedQueue.Count());
            Assert.Equal(state2.Object, dequeuedQueue.Peek());
        }

        [Fact]
        public void TestPeek()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var stateTracker = new DifferentialQueue();
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object);

            // Act
            var peekedState = newQueue.Peek();

            // Assert
            Assert.Equal(state1.Object, peekedState);
        }

        [Fact]
        public void TestClear()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var stateTracker = new DifferentialQueue();
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object);

            // Act
            var clearedQueue = newQueue.Clear();

            // Assert
            Assert.Equal(0, clearedQueue.Count());
        }
    }
}