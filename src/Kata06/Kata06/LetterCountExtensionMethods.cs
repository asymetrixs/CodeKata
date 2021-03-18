using System.Collections.Generic;
using System.Linq;

namespace CodeKata.Kata06
{
    public static class LetterCountExtensionMethods
    {
        /// <summary>
        /// Returns the letter count ordered as string
        /// </summary>
        /// <param name="me">Letter count</param>
        /// <returns></returns>
        public static string GetStringRepresentation(this IList<LetterCount> me)
        {
            /// Order by letter, then join the <see cref="LetterCount.Representation"/>
            return string.Join(',', me.OrderBy(m => m.Letter).Select(m => m.Representation));
        }
    }
}
