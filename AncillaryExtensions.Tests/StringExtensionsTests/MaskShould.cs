using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AncillaryExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class MaskShould
    {
        [DataTestMethod]
        [DataRow(null, 0, 0, null)]
        [DataRow("", 0, 0, "")]
        [DataRow("1", 0, 1, "*")]
        [DataRow("1", 0, 0, "1")]
        [DataRow("12", 0, 2, "**")]
        [DataRow("12", 0, 1, "*2")]
        [DataRow("12", 1, 1, "1*")]
        [DataRow("123", 0, 3, "***")]
        [DataRow("1234", 0, 4, "****")]
        [DataRow("12345", 0, 5, "*****")]
        [DataRow("12345", 1, 4, "1****")]
        [DataRow("12345", 2, 3, "12***")]
        [DataRow("12345", 3, 2, "123**")]
        [DataRow("12345", 4, 1, "1234*")]
        [DataRow("123456", 4, 2, "1234**")]
        [DataRow("1234567", 4, 3, "1234***")]
        [DataRow("123456789", 4, 5, "1234*****")]
        [DataRow("1234567890", 2, 4, "12****7890")]
        [DataRow("1234567890", 3, 3, "123***7890")]
        [DataRow("1234567890", 4, 2, "1234**7890")]
        [DataRow("1234567890", 5, 1, "12345*7890")]
        [DataRow("1234567890", 6, 1, "123456*890")]
        public void MaskAsTold(string source, int start, int count, string expected)
        {
            // Act
            var actual = source.Mask('*', start, count); // show last four of credit card

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
