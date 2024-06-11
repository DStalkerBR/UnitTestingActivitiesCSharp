namespace Atividade08.Tests
{
    public class StatisticsTest
    {
        [Fact]
        public void CalculateAverage_ShouldThrowArgumentException_WhenNumbersListIsNull()
        {
            // Arrange
            var statistics = new Statistics();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(null));
        }

        [Fact]
        public void CalculateAverage_ShouldThrowArgumentException_WhenNumbersListIsEmpty()
        {
            // Arrange
            var statistics = new Statistics();
            var emptyList = new List<int>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(emptyList));
        }

        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage_WhenNumbersListIsValid()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            double average = statistics.CalculateAverage(numbers);

            // Assert
            Assert.Equal(3.0, average, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage_ForSingleElementList()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int> { 42 };

            // Act
            double average = statistics.CalculateAverage(numbers);

            // Assert
            Assert.Equal(42.0, average, 1);
        }
    }
}
