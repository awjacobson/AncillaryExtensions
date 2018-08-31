using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class SplitAndTrimShould
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var source = "1, 2, 3, 4";

            // Act
            var actual = source.SplitAndTrim(',').ToList();

            // Assert
            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual("1", actual[0]);
            Assert.AreEqual("2", actual[1]);
            Assert.AreEqual("3", actual[2]);
            Assert.AreEqual("4", actual[3]);
        }
    }
}
