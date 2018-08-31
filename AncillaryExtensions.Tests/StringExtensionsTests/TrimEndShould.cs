using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class TrimEndShould
    {
        [TestMethod]
        public void TrimTrailingStringWhenValueIsFound()
        {
            // Arrange
            const string EOL = "<br/>";
            var source = $"LineOfText{EOL}";

            // Act
            var actual = source.TrimEnd(EOL);

            // Assert
            Assert.AreEqual("LineOfText", actual);
        }

        [TestMethod]
        public void ReturnSourceWhenValueIsNotFound()
        {
            // Arrange
            const string EOL = "<br/>";
            var source = $"LineOfText";

            // Act
            var actual = source.TrimEnd(EOL);

            // Assert
            Assert.AreEqual("LineOfText", actual);
        }

        [TestMethod]
        public void ReturnSourceWhenValueIsNull()
        {
            // Arrange
            const string EOL = default(string);
            var source = $"LineOfText";

            // Act
            var actual = source.TrimEnd(EOL);

            // Assert
            Assert.AreEqual("LineOfText", actual);
        }

        [TestMethod]
        public void ReturnNullWhenSourceIsNull()
        {
            // Arrange
            const string EOL = "<br/>";
            var source = default(string);

            // Act
            var actual = source.TrimEnd(EOL);

            // Assert
            Assert.IsNull(actual);
        }
    }
}
