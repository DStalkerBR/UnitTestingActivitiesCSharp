namespace Atividade11.Tests
{
    public class CustomSorterTest
    {
        [Fact]
        public void SortDescending_ShouldReturnEmptyList_WhenInputIsEmpty()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int>();

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void SortDescending_ShouldReturnListSortedInDescendingOrder_WhenInputIsValid()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int> { 5, 3, 8, 1, 2 };

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            var expected = new List<int> { 8, 5, 3, 2, 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldReturnSameList_WhenInputHasOneElement()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int> { 42 };

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            var expected = new List<int> { 42 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldHandleNegativeNumbers()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int> { -3, -1, -2, -5, 0 };

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            var expected = new List<int> { 0, -1, -2, -3, -5 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortDescending_ShouldHandleListWithDuplicateElements()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int> { 5, 3, 8, 1, 8, 3, 2 };

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            var expected = new List<int> { 8, 8, 5, 3, 3, 2, 1 };
            Assert.Equal(expected, result);
        }
    }
}
