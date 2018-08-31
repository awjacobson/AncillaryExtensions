using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class MaskRightShould
    {
        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("", "")]
        [DataRow("1", "1")]
        [DataRow("12", "12")]
        [DataRow("123", "123")]
        [DataRow("1234", "1234")]
        [DataRow("11223", "11223")]
        [DataRow("112233", "112233")]
        [DataRow("1122334", "112233*")]
        [DataRow("11223344", "112233**")]
        [DataRow("112233445", "112233***")]
        [DataRow("1122334455", "112233****")]
        [DataRow("11223344556", "112233*****")]
        [DataRow("112233445566", "112233******")]
        public void MaskCharacterOnTheRight(string input, string expected)
        {
            // Act
            var actual = input.MaskRight(6);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
