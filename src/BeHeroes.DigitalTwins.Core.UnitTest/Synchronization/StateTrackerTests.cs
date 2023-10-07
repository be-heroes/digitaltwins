using System.Collections.Immutable;
using BeHeroes.DigitalTwins.Core.Synchronization;
using Moq;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateTrackerTests
    {
        [Fact]
        public void TestEnqueue()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var state3 = new Mock<IStateBackup>();
            var stateTracker = new StateTracker(new Mock<IStateSequencer>().Object);

            // Act
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object).Enqueue(state3.Object);

            // Assert
            Assert.Equal(3, newQueue.Count());
            Assert.Equal(state1.Object, newQueue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var state3 = new Mock<IStateBackup>();
            var stateTracker = new StateTracker(new Mock<IStateSequencer>().Object);
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object).Enqueue(state3.Object);

            // Act
            var dequeuedQueue = newQueue.Dequeue();

            // Assert
            Assert.Equal(2, dequeuedQueue.Count());
            Assert.Equal(state2.Object, dequeuedQueue.Peek());
        }

        [Fact]
        public void TestPeek()
        {
            // Arrange
            var state1 = new Mock<IState>();
            var state2 = new Mock<IStateShadow>();
            var state3 = new Mock<IStateBackup>();
            var stateTracker = new StateTracker(new Mock<IStateSequencer>().Object);
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object).Enqueue(state3.Object);

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
            var state3 = new Mock<IStateBackup>();
            var stateTracker = new StateTracker(new Mock<IStateSequencer>().Object);
            var newQueue = stateTracker.Enqueue(state1.Object).Enqueue(state2.Object).Enqueue(state3.Object);

            // Act
            var clearedQueue = newQueue.Clear();

            // Assert
            Assert.Equal(0, clearedQueue.Count());
        }
    }
}