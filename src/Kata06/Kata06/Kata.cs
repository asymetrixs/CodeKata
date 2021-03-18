using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeKata.Kata06
{
    public static class Kata
    {
        /// <summary>
        /// Hashset will hold all words
        /// </summary>
        public static ConcurrentDictionary<string, List<string>> Words { get; private set; } = new();

        /// <summary>
        /// Loads file containing all words
        /// </summary>
        public static void SearchForAnagrams(string[] data)
        {
            Parallel.ForEach(data, (text) =>
            {
                // Skip empty strings
                if (string.IsNullOrWhiteSpace(text))
                {
                    return;
                }

                // Lower case
                text = text.ToLowerInvariant();

                // Get letter count
                string letterCount = text.CalculateLetterCount();

                // Add/update dictionary
                Words.AddOrUpdate(letterCount, new List<string> { text }, (letterCount, oldValue) =>
                {
                    oldValue.Add(text);
                    return oldValue;
                });
            });
        }
    }
}
