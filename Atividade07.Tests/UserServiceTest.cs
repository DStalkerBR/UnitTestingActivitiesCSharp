using NSubstitute;

namespace Atividade07.Tests
{
    public class UserServiceTest
    {
        [Fact]
        public void SaveUser_ShouldThrowArgumentException_WhenUserNameIsNullOrEmpty()
        {
            // Arrange
            var mockDb = Substitute.For<IDatabase>();
            var userService = new UserService(mockDb);
            var userWithEmptyName = new User(string.Empty, "email@example.com");
            var userWithNullName = new User(null, "email@example.com");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(userWithEmptyName));
            Assert.Throws<ArgumentException>(() => userService.SaveUser(userWithNullName));
        }

        [Fact]
        public void SaveUser_ShouldThrowArgumentException_WhenUserEmailIsNullOrEmpty()
        {
            // Arrange
            var mockDb = Substitute.For<IDatabase>();
            var userService = new UserService(mockDb);
            var userWithEmptyEmail = new User("John Doe", string.Empty);
            var userWithNullEmail = new User("John Doe", null);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(userWithEmptyEmail));
            Assert.Throws<ArgumentException>(() => userService.SaveUser(userWithNullEmail));
        }

        [Fact]
        public void SaveUser_ShouldCallSaveUserOnDatabase_WhenUserIsValid()
        {
            // Arrange
            var mockDb = Substitute.For<IDatabase>();
            var userService = new UserService(mockDb);
            var validUser = new User("John Doe", "john.doe@example.com");

            // Act
            userService.SaveUser(validUser);

            // Assert
            mockDb.Received(1).SaveUser(validUser);
        }
    }
}
