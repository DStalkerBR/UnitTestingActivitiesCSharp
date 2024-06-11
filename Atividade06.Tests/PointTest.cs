namespace Atividade06.Tests;
public class PointTest
{
    [Fact]
    public void DistanceTo_ShouldCalculateCorrectDistance()
    {
        // Arrange
        var point1 = new Point(0, 0);
        var point2 = new Point(3, 4);

        // Act
        double distance = point1.DistanceTo(point2);

        // Assert
        Assert.Equal(5, distance, 5);
    }

    [Fact]
    public void DistanceTo_ShouldThrowArgumentNullException_WhenOtherIsNull()
    {
        // Arrange
        var point1 = new Point(0, 0);

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => point1.DistanceTo(null));
    }

    [Fact]
    public void Constructor_ShouldSetPropertiesCorrectly()
    {
        // Arrange & Act
        var point = new Point(2, 3);

        // Assert
        Assert.Equal(2, point.X);
        Assert.Equal(3, point.Y);
    }
}
