using NSubstitute;

namespace Atividade10.Tests
{
    public class UserManagerTest
    {
        [Fact]
        public void FetchUserInfo_ShouldReturnUser_WhenUserIdIsValid()
        {
            // Arrange
            var userServiceMock = Substitute.For<IUserService>();
            var user = new User("Test User", "test@example.com");
            userServiceMock.GetUserInfo(1).Returns(user);

            var userManager = new UserManager(userServiceMock);

            // Act
            var result = userManager.FetchUserInfo(1);

            // Assert
            Assert.Equal("Test User", result.Name);
            Assert.Equal("test@example.com", result.Email);
        }

        [Fact]
        public void FetchUserInfo_ShouldCallGetUserInfoOnUserService_WhenUserIdIsProvided()
        {
            // Arrange
            var userServiceMock = Substitute.For<IUserService>();
            var userManager = new UserManager(userServiceMock);

            // Act
            userManager.FetchUserInfo(1);

            // Assert
            userServiceMock.Received(1).GetUserInfo(1);
        }
    }
}
