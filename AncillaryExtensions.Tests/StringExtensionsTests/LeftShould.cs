using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class LeftShould
    {
        [TestMethod]
        public void ReturnNullWhenPassedNull()
        {
            // Arrange
            String testString = null;

            // Act
            var actual = testString.Left(7);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ReturnEmptyStringWhenPassedEmptyString()
        {
            // Arrange
            String testString = String.Empty;

            // Act
            var actual = testString.Left(7);

            // Assert
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        public void ReturnOriginalStringWhenOriginalStringIsShorterThanMaxLength()
        {
            // Arrange
            String testString = " ";

            // Act
            var actual = testString.Left(7);

            // Assert
            Assert.AreEqual(" ", actual);
        }

        [TestMethod]
        public void ReturnTheFirstMaxLengthCharacters()
        {
            // Arrange
            String testString = "                   ";

            // Act
            var actual = testString.Left(7);

            // Assert
            Assert.AreEqual("       ", actual);
        }

        [TestMethod]
        public void ReturnAnEmptyStringWhenMaxLengthIsZero()
        {
            // Arrange
            String testString = "TestString";

            // Act
            var actual = testString.Left(0);

            // Assert
            Assert.AreEqual(string.Empty, actual);
        }
    }
}
