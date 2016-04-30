using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void MergeSortTest()
        {
            //Arrange
            var input = new[] { 5, 2, 4, 6, 1, 3, 9, 8, 7, 0 };

            //Act
            var result = Sort.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(result, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }
    }
}