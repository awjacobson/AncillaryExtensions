using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class ReplaceShould
    {
        [TestMethod]
        public void ReplaceByGroupName()
        {
            // Arrange
            var regex = new Regex(@".*_(?<id>\d+)_.*", RegexOptions.IgnoreCase);

            // Act
            var actual = "abc_123_def".Replace(regex, "id", "456");

            // Assert
            Assert.AreEqual("abc_456_def", actual);
        }
    }
}
