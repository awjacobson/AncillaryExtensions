using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AncillaryExtensions
{
    /// <summary>
    /// Extensions to the <see cref="string"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a string containing a specified number of characters from the
        /// left side of a string.
        /// </summary>
        /// <remarks>
        /// C# implementation of the Visual Basic Left function
        /// https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/left-function
        /// </remarks>
        /// <param name="value"></param>
        /// <param name="maxLength">
        /// Integer indicating how many characters to return.
        /// If 0, a zero-length string ("") is returned. If greater than or equal to
        /// the number of characters in string, the entire string is returned.
        /// </param>
        /// <returns></returns>
        public static string Left(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return value.Length <= maxLength
                ? value
                : value.Substring(0, maxLength);
        }

        /// <summary>
        /// Returns a string containing a specified number of characters from the
        /// right side of a string.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength">
        /// Integer indicating how many characters to return.
        /// If 0, a zero-length string ("") is returned. If greater than or equal to
        /// the number of characters in string, the entire string is returned.
        /// </param>
        /// <returns></returns>
        public static string Right(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return (value.Length > maxLength)
                ? value.Substring(value.Length - maxLength, maxLength)
                : value;
        }

        /// <summary>
        /// Removes string from the end of the current <see cref="String"/> object.
        /// </summary>
        /// <remarks>
        /// https://stackoverflow.com/a/7170950
        /// </remarks>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string TrimEnd(this string source, string value)
        {
            if (source == null || value == null || !source.EndsWith(value))
            {
                return source;
            }

            return source.Remove(source.LastIndexOf(value));
        }

        /// <summary>
        /// Mask the characters on the left (start of the string).
        /// </summary>
        /// <example>************7788</example>
        /// <param name="source"></param>
        /// <param name="count">The maximum number of characters on the right to leave unmasked.</param>
        /// <returns></returns>
        public static string MaskLeft(this string source, int count)
        {
            if (string.IsNullOrEmpty(source)) return source;

            var count1 = Math.Max(source.Length - count, 0);
            return source.Mask('*', 0, count1);
        }

        /// <summary>
        /// Mask the characters on the right (end of the string).
        /// </summary>
        /// <example>112233**********</example>
        /// <param name="source"></param>
        /// <param name="count">The maximum number of characters on the left to leave unmasked.</param>
        /// <returns></returns>
        public static string MaskRight(this string source, int count)
        {
            if (string.IsNullOrEmpty(source)) return source;

            var start = Math.Min(source.Length, count);
            var count1 = Math.Min(source.Length - start, count);
            return source.Mask('*', start, count1);
        }

        /// <summary>
        /// Mask characters of a string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="maskValue"></param>
        /// <param name="start">Index of where masking is to start.</param>
        /// <param name="count">Number of characters to mask.</param>
        /// <returns></returns>
        public static string Mask(this string source, char maskValue, int start, int count)
        {
            if (string.IsNullOrEmpty(source)) return source;

            var firstPart = source.Substring(0, start);
            var lastPart = source.Substring(start + count);
            var middlePart = new string(maskValue, count);
            return firstPart + middlePart + lastPart;
        }

        /// <summary>
        /// Returns a sequence of strings that contains the substrings in this instance that are delimitted by
        /// elements of a specified Unicode character array and with leading and trailing white-space characters removed.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="separator">An array of Unicode characters that delimit the substrings in this instance,
        /// an empty array that contains no delimiters, or null.</param>
        /// <returns></returns>
        public static IEnumerable<string> SplitAndTrim(this string source, params char[] separator)
        {
            return source.Split(separator).Select(x => x.Trim());
        }

        /// <summary>
        /// Replace named group in regex with value
        /// </summary>
        /// <remarks>
        /// https://stackoverflow.com/a/13342795
        /// </remarks>
        /// <param name="input"></param>
        /// <param name="regex"></param>
        /// <param name="groupName"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        public static string Replace(this string input, Regex regex, string groupName, string replacement)
        {
            return regex.Replace(input, m =>
            {
                return ReplaceNamedGroup(groupName, replacement, m);
            });
        }

        private static string ReplaceNamedGroup(string groupName, string replacement, Match m)
        {
            string capture = m.Value;
            capture = capture.Remove(m.Groups[groupName].Index - m.Index, m.Groups[groupName].Length);
            capture = capture.Insert(m.Groups[groupName].Index - m.Index, replacement);
            return capture;
        }
    }
}