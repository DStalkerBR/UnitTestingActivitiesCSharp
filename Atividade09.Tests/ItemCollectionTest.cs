namespace Atividade09.Tests
{
    public class ItemCollectionTest
    {
        [Fact]
        public void AddItem_ShouldThrowArgumentException_WhenItemIsNull()
        {
            // Arrange
            var itemCollection = new ItemCollection();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => itemCollection.AddItem(null));
        }

        [Fact]
        public void AddItem_ShouldAddItemToCollection_WhenItemIsValid()
        {
            // Arrange
            var itemCollection = new ItemCollection();
            var item = new Item("Item1");

            // Act
            itemCollection.AddItem(item);

            // Assert
            Assert.Contains(item, itemCollection.GetItems());
        }

        [Fact]
        public void RemoveItem_ShouldThrowArgumentException_WhenItemNotFound()
        {
            // Arrange
            var itemCollection = new ItemCollection();
            var item = new Item("Item1");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => itemCollection.RemoveItem(item));
        }

        [Fact]
        public void RemoveItem_ShouldRemoveItemFromCollection_WhenItemIsFound()
        {
            // Arrange
            var itemCollection = new ItemCollection();
            var item = new Item("Item1");
            itemCollection.AddItem(item);

            // Act
            itemCollection.RemoveItem(item);

            // Assert
            Assert.DoesNotContain(item, itemCollection.GetItems());
        }

        [Fact]
        public void GetItems_ShouldReturnAllItemsInCollection()
        {
            // Arrange
            var itemCollection = new ItemCollection();
            var item1 = new Item("Item1");
            var item2 = new Item("Item2");
            itemCollection.AddItem(item1);
            itemCollection.AddItem(item2);

            // Act
            var items = itemCollection.GetItems();

            // Assert
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }
    }
}
