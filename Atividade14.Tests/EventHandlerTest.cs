using NSubstitute;

namespace Atividade14.Tests
{
    public class EventHandlerTest
    {
        [Fact]
        public void HandleEvent_ShouldCallSendEmail_WithCorrectParameters()
        {
            // Arrange
            var emailServiceMock = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailServiceMock);
            var eventMessage = "An important event occurred";

            // Act
            eventHandler.HandleEvent(eventMessage);

            // Assert
            emailServiceMock.Received(1).SendEmail(
                "test@example.com",
                "Event Occurred",
                eventMessage
            );
        }
    }
}
