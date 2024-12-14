using WarehouseLibrary;
namespace WarehouseUnitTests
{
    [TestClass]
    public class SortingArrayTest
    {
        [TestMethod]
        public void ArraySortingTest()
        {
            // Arrange
            int[] toSortArray = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };

            // Act
            ArrayClass.SortArray(toSortArray);

            // Assert
            CollectionAssert.AreEqual(toSortArray, sortedArray);
        }
    }
}