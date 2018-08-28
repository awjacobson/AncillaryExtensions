using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.IEnumerableExtensionsTests
{
    [TestClass]
    public class GetPageShould
    {
        [TestMethod]
        public void ReturnOriginalWhenLessThanPageSize()
        {
            // Arrange
            var items = new List<int> { 0, 1, 2, 3, 4, 5 };

            // Act
            var page = items.GetPage(0, 10);

            // Assert
            Assert.AreEqual(6, page.Count());
            Assert.AreEqual(0, page.ElementAt(0));
            Assert.AreEqual(1, page.ElementAt(1));
            Assert.AreEqual(2, page.ElementAt(2));
            Assert.AreEqual(3, page.ElementAt(3));
            Assert.AreEqual(4, page.ElementAt(4));
            Assert.AreEqual(5, page.ElementAt(5));
        }

        [TestMethod]
        public void ReturnFirstOfTwoPages()
        {
            // Arrange
            var items = new List<int> { 0, 1, 2, 3, 4, 5 };

            // Act
            var page = items.GetPage(0, 3);

            // Assert
            Assert.AreEqual(3, page.Count());
            Assert.AreEqual(0, page.ElementAt(0));
            Assert.AreEqual(1, page.ElementAt(1));
            Assert.AreEqual(2, page.ElementAt(2));
        }

        [TestMethod]
        public void ReturnSecondOfTwoPages()
        {
            // Arrange
            var items = new List<int> { 0, 1, 2, 3, 4, 5 };

            // Act
            var page = items.GetPage(1, 3);

            // Assert
            Assert.AreEqual(3, page.Count());
            Assert.AreEqual(3, page.ElementAt(0));
            Assert.AreEqual(4, page.ElementAt(1));
            Assert.AreEqual(5, page.ElementAt(2));
        }
    }
}
