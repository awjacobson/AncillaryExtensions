using System.Collections.Generic;
using System.Linq;

namespace AncillaryExtensions
{
    /// <summary>
    /// Extensions to the the <see cref="IEnumerable"/> interface.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Get a page of items from a list of items.
        /// </summary>
        /// <remarks>
        /// https://stackoverflow.com/questions/4472294/paging-through-an-ienumerable
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="page">0-based page number (to call the first page you need to pass 0).</param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetPage<T>(this IEnumerable<T> input, int page, int pagesize)
        {
            return input.Skip(page * pagesize).Take(pagesize);
        }
    }
}
