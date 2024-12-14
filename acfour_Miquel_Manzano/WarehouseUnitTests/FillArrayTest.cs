using WarehouseLibrary;
namespace WarehouseUnitTests
{
    [TestClass]
    public class FillArrayTest
    {
        [TestMethod]
        public void ArrayFillingTest()
        {
            // Arrange
            const int ValorInicial = 0;
            const int arraySize = 5;
            int[] toFillArray = new int[arraySize];
            int[] FilledArray = { 1, 2, 3, 4, 5 };

            // Act
            ArrayClass.FillArray(toFillArray, ValorInicial);

            // Assert
            CollectionAssert.AreEqual(toFillArray, FilledArray);
        }
    }
}