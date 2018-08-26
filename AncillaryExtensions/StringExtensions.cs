using System;

namespace AncillaryExtensions
{
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
        /// <param name="count">The maximum number of characters to remain showing at the end of the given string.</param>
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
        /// <param name="count"></param>
        /// <returns></returns>
        public static string MaskRight(this string source, int count)
        {
            if (string.IsNullOrEmpty(source)) return source;

            var start = Math.Min(source.Length, count);
            var count1 = Math.Min(source.Length - start, count);
            return source.Mask('*', start, count1);
        }

        /// <summary>
        /// 
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
    }
}