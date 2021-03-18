using System.Collections.Generic;
using System.Linq;

namespace CodeKata.Kata06
{
    public static class StringExtensionMethods
    {
        /// <summary>
        /// Count letters in a string
        /// </summary>
        /// <param name="text">Text to count letters of</param>
        /// <returns>List of counted letters</returns>
        public static string CalculateLetterCount(this string text)
        {
            // List to count each character
            var letterCounts = new List<LetterCount>();

            // Loop through alphabet
            int count;
            foreach (var character in text.Distinct())
            {
                // Count appearance of letter
                count = text.Count(c => c == character);

                // If letter appears, add to list
                if (count > 0)
                {
                    letterCounts.Add(new LetterCount()
                    {
                        Letter = character,
                        Count = count,
                    });
                }
            }

            return letterCounts.GetStringRepresentation();
        }
    }
}
