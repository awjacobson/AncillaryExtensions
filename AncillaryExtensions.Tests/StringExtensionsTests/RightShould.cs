using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class RightShould
    {
        [TestMethod]
        public void ReturnNullWhenPassedNull()
        {
            // Arrange
            String testString = null;

            // Act
            var actual = testString.Right(7);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ReturnEmptyStringWhenPassedEmptyString()
        {
            // Arrange
            String testString = String.Empty;

            // Act
            var actual = testString.Right(7);

            // Assert
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        public void ReturnOriginalStringWhenOriginalStringIsShorterThanMaxLength()
        {
            // Arrange
            String testString = "X";

            // Act
            var actual = testString.Right(7);

            // Assert
            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void ReturnTheRightMaxLengthCharacters()
        {
            // Arrange
            String testString = "1234567890";

            // Act
            var actual = testString.Right(7);

            // Assert
            Assert.AreEqual("4567890", actual);
        }

        [TestMethod]
        public void ReturnAnEmptyStringWhenMaxLengthIsZero()
        {
            // Arrange
            String testString = "TestString";

            // Act
            var actual = testString.Right(0);

            // Assert
            Assert.AreEqual(string.Empty, actual);
        }
    }
}
