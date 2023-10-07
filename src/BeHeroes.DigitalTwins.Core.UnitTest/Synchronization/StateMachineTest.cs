using BeHeroes.DigitalTwins.Core.Synchronization;
using Moq;

namespace BeHeroes.DigitalTwins.Core.UnitTest.Synchronization
{
    public class StateMachineTests
    {
        [Fact]
        public void Constructor_SetsProperties()
        {
            // Arrange
            var stateTracker = new StateTracker(new Mock<IStateSequencer>().Object);
            var stateMock = new Mock<IState>();
            var stateShadowMock = new Mock<IStateShadow>();
            var stateBackupMock = new Mock<IStateBackup>();

            // Act
            var stateMachine = new StateMachine(stateTracker, stateMock.Object, stateShadowMock.Object, stateBackupMock.Object);

            // Assert                
            Assert.Equal(stateTracker, stateMachine.StateTracker);
            Assert.Equal(stateMock.Object, stateMachine.State);
            Assert.Equal(stateShadowMock.Object, stateMachine.StateShadow);
            Assert.Equal(stateBackupMock.Object, stateMachine.StateBackup);
        }
    }
}