using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class MaskLeftShould
    {
        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("", "")]
        [DataRow("1", "1")]
        [DataRow("12", "12")]
        [DataRow("123", "123")]
        [DataRow("1234", "1234")]
        [DataRow("11223", "*1223")]
        [DataRow("112233", "**2233")]
        [DataRow("1122334", "***2334")]
        [DataRow("11223344", "****3344")]
        [DataRow("112233445", "*****3445")]
        [DataRow("1122334455", "******4455")]
        [DataRow("11223344556", "*******4556")]
        [DataRow("112233445566", "********5566")]
        [DataRow("1122334455667", "*********5667")]
        [DataRow("11223344556677", "**********6677")]
        [DataRow("112233445566778", "***********6778")]
        [DataRow("1122334455667788", "************7788")]
        public void MaskCharactersOnTheLeft(string input, string expected)
        {
            // Act
            var actual = input.MaskLeft(4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
